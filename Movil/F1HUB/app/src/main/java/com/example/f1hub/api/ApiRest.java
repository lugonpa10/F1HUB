package com.example.f1hub.api;

import android.util.Log;

import org.json.JSONObject;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.io.OutputStream;
import java.net.HttpURLConnection;
import java.net.URL;
import java.nio.charset.StandardCharsets;

public class ApiRest {
    public void resgistroUsuario(String nombre, String nombreUsuario, String apellidos, String passwordHash, String email, String genero, String fechaNacimiento) {
        new Thread(() -> {
            try {
                URL url = new URL("http://192.130.0.125:8080/f1hub/rest/usuarios/registro");
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
            URL url = new URL("http://192.130.0.125:8080/f1hub/rest/usuarios/inicioSesion");
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
}






