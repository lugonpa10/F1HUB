package com.example.f1hub.api;

import android.util.Log;

import com.example.f1hub.models.Publicaciones;

import org.json.JSONArray;
import org.json.JSONObject;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.io.OutputStream;
import java.net.HttpURLConnection;
import java.net.URL;
import java.nio.charset.StandardCharsets;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import java.util.Locale;

public class ApiRest {
    public void resgistroUsuario(String nombre, String nombreUsuario, String apellidos, String passwordHash, String email, String genero, String fechaNacimiento) {
        new Thread(() -> {
            try {
                URL url = new URL("http://192.168.1.42:8080/f1hub/rest/usuarios/registro");
                HttpURLConnection con = (HttpURLConnection) url.openConnection();
                con.setRequestMethod("POST");
                con.setRequestProperty("Content-type", "application/json");
                con.setDoOutput(true);

                JSONObject json = new JSONObject();

                json.put("nombre", nombre);
                json.put("apellidos",apellidos);
                json.put("nombreUsuario", nombreUsuario);
                json.put("passwordHash", passwordHash);
                json.put("email", email);
                json.put("genero", genero);
                json.put("fechaNacimiento", fechaNacimiento);


                System.out.println(json);

                try (OutputStream os = con.getOutputStream()) {
                    os.write(json.toString().getBytes(StandardCharsets.UTF_8));
                } catch (IOException e) {

                }

                int code = con.getResponseCode();
                Log.i("CODIGO APIREST", "El codigo resulante es " + code);


            } catch (Exception e) {
                Log.e("API_ERROR", "Error al registrar usuario", e);
            }
        }).start();
    }

    public interface LoginCallback {
        void onResult(boolean success,JSONObject userData);
    }

    public void inicioSesion(String nombreUsuario, String password, LoginCallback callback) { // Cambiar a get y queryParam

        new Thread(() -> {
        try {
            URL url = new URL("http://192.168.1.42:8080/f1hub/rest/usuarios/inicioSesion");
            HttpURLConnection con = (HttpURLConnection) url.openConnection();
            con.setRequestMethod("POST");
            con.setRequestProperty("Content-type", "application/json");
            con.setDoOutput(true);

            JSONObject json = new JSONObject();
            json.put("nombreUsuario", nombreUsuario);
            json.put("passwordHash", password);
            System.out.println(json);

            try(OutputStream os = con.getOutputStream()) {
                os.write(json.toString().getBytes(StandardCharsets.UTF_8));
            }

            int code = con.getResponseCode();

            System.out.println(code);

            if (code == 200){

                InputStream is = con.getInputStream();
                BufferedReader reader = new BufferedReader(new InputStreamReader(is, StandardCharsets.UTF_8));
                StringBuilder response = new StringBuilder();
                String line;

                while ((line = reader.readLine()) != null) {
                    response.append(line);
                }
                reader.close();
                JSONObject userData = new JSONObject(response.toString());
                System.out.println("User data: " + userData);
                callback.onResult(true,userData);
            }else {
                callback.onResult(false,null);
            }



        } catch (Exception e) {
            Log.e("API_ERROR", "Error al validar usuario", e);
            callback.onResult(false,null);

        }
        }).start();

    }

    public interface PublicacionCallback {
        void onResult(boolean success);
    }

    public void subirPublicacion(int idUsuario, String texto, PublicacionCallback callback) {
        new Thread(() -> {
            try {
                URL url = new URL("http://192.168.1.42:8080/f1hub/rest/publicaciones/subir");
                HttpURLConnection con = (HttpURLConnection) url.openConnection();
                con.setRequestMethod("POST");
                con.setRequestProperty("Content-type", "application/json");
                con.setDoOutput(true);

                JSONObject jsonUsuario = new JSONObject();
                jsonUsuario.put("idUsuario", idUsuario);

                JSONObject json = new JSONObject();
                json.put("usuario", jsonUsuario);
                json.put("texto", texto);

                try (OutputStream os = con.getOutputStream()) {
                    os.write(json.toString().getBytes(StandardCharsets.UTF_8));
                }

                int code = con.getResponseCode();

                callback.onResult(code == 200);

            } catch (Exception e) {
                Log.e("API_ERROR", "Error al subir publicacion", e);
                callback.onResult(false);
            }
        }).start();
    }

    public interface PublicacionesCallback {
        void onResult(List<Publicaciones> publicaciones);
    }

    public void obtenerTodasPublicaciones(PublicacionesCallback callback) {
        new Thread(() -> {
            try {
                URL url = new URL("http://192.168.1.42:8080/f1hub/rest/publicaciones/todas");
                HttpURLConnection con = (HttpURLConnection) url.openConnection();
                con.setRequestMethod("GET");

                int code = con.getResponseCode();
                if (code == 200) {
                    InputStream is = con.getInputStream();
                    BufferedReader reader = new BufferedReader(new InputStreamReader(is, StandardCharsets.UTF_8));
                    StringBuilder response = new StringBuilder();
                    String line;
                    while ((line = reader.readLine()) != null) {
                        response.append(line);
                    }
                    reader.close();

                    JSONArray jsonArray = new JSONArray(response.toString());
                    List<Publicaciones> lista = new ArrayList<>();
                    for (int i = 0; i < jsonArray.length(); i++) {
                        JSONObject obj = jsonArray.getJSONObject(i);
                        String nombreUsuario = obj.getJSONObject("usuario").optString("nombreUsuario", "");
                        String texto = obj.optString("texto", "");
                        String fecha;
                        long timestamp = obj.optLong("fechaPublicacion", 0);
                        if(timestamp >0)

                        {
                            SimpleDateFormat sdf = new SimpleDateFormat("dd/MM/yyyy HH:mm", Locale.getDefault());
                            fecha = sdf.format(new Date(timestamp));
                        } else

                        {
                            fecha = "";
                        }
                        lista.add(new Publicaciones(nombreUsuario, texto, fecha));
                    }
                    callback.onResult(lista);
                } else {
                    callback.onResult(new ArrayList<>());
                }
            } catch (Exception e) {
                Log.e("API_ERROR", "Error al obtener publicaciones", e);
                callback.onResult(new ArrayList<>());
            }
        }).start();
    }

    public void obtenerPublicacionesUsuario(int idUsuario, String nombreUsuario, PublicacionesCallback callback) {
        new Thread(() -> {
            try {
                URL url = new URL("http://192.168.1.42:8080/f1hub/rest/publicaciones/" + idUsuario);
                HttpURLConnection con = (HttpURLConnection) url.openConnection();
                con.setRequestMethod("GET");

                int code = con.getResponseCode();
                if (code == 200) {
                    InputStream is = con.getInputStream();
                    BufferedReader reader = new BufferedReader(new InputStreamReader(is, StandardCharsets.UTF_8));
                    StringBuilder response = new StringBuilder();
                    String line;
                    while ((line = reader.readLine()) != null) {
                        response.append(line);
                    }
                    reader.close();

                    JSONArray jsonArray = new JSONArray(response.toString());
                    List<Publicaciones> lista = new ArrayList<>();
                    for (int i = 0; i < jsonArray.length(); i++) {
                        JSONObject obj = jsonArray.getJSONObject(i);
                        String texto = obj.optString("texto", "");
                        String fecha;
                        long timestamp = obj.optLong("fechaPublicacion", 0);
                        if (timestamp > 0) {
                            SimpleDateFormat sdf = new SimpleDateFormat("dd/MM/yyyy HH:mm", Locale.getDefault());
                            fecha = sdf.format(new java.util.Date(timestamp));
                        } else {
                            fecha = "";
                        }
                        Publicaciones publis = new Publicaciones(nombreUsuario,texto,fecha);
                        publis.setId(obj.optInt("idPubli",0));
                        lista.add(publis);


                    }
                    callback.onResult(lista);
                } else {
                    callback.onResult(new ArrayList<>());
                }
            } catch (Exception e) {
                Log.e("API_ERROR", "Error al obtener publicaciones del usuario", e);
                callback.onResult(new ArrayList<>());
            }
        }).start();
    }

    public interface EliminarCallback {
        void onResult(boolean success);
    }

    public void eliminarPublicacion(int idPublicacion, EliminarCallback callback) {
        new Thread(() -> {
            try {
                URL url = new URL("http://192.168.1.42:8080/f1hub/rest/publicaciones/" + idPublicacion);
                HttpURLConnection con = (HttpURLConnection) url.openConnection();
                con.setRequestMethod("DELETE");

                int code = con.getResponseCode();
                callback.onResult(code == 200);

            } catch (Exception e) {
                Log.e("API_ERROR", "Error al eliminar publicacion", e);
                callback.onResult(false);
            }
        }).start();
    }

    public interface EditarCallback {
        void onResult(boolean success);
    }

    public void editarUsuario(String nombreUsuario, String nombre, String apellidos, String email,String fechaNacimiento, EditarCallback callback) {
        new Thread(() -> {
            try {
                URL url = new URL("http://192.168.1.42:8080/f1hub/rest/usuarios/editar");
                HttpURLConnection con = (HttpURLConnection) url.openConnection();
                con.setRequestMethod("PUT");
                con.setRequestProperty("Content-type", "application/json");
                con.setDoOutput(true);

                JSONObject json = new JSONObject();
                json.put("nombreUsuario", nombreUsuario);
                json.put("nombre", nombre);
                json.put("apellidos", apellidos);
                json.put("email", email);
                json.put("fechaNacimiento", Long.parseLong(fechaNacimiento));


                try (OutputStream os = con.getOutputStream()) {
                    os.write(json.toString().getBytes(StandardCharsets.UTF_8));
                }

                int code = con.getResponseCode();

                callback.onResult(code == 200);

            } catch (Exception e) {
                Log.e("API_ERROR", "Error al editar usuario", e);
                callback.onResult(false);
            }
        }).start();
    }
}






