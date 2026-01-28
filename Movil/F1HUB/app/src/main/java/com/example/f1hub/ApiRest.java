package com.example.f1hub;

import android.util.Log;

import org.json.JSONObject;

import java.io.IOException;
import java.io.OutputStream;
import java.net.HttpURLConnection;
import java.net.URL;
import java.nio.charset.StandardCharsets;
import java.sql.Date;
import java.sql.Timestamp;

public class ApiRest {
    public void resgistroUsuario(String nombre, String nombreUsuario,  String apellidos,String passwordHash, String email, String genero, String fechaNacimiento) {
        new Thread(() -> {
            try {
                URL url = new URL("http://192.130.0.125:8080/f1hub/rest/usuarios/registro");
                HttpURLConnection con = (HttpURLConnection) url.openConnection();
                con.setRequestMethod("POST");
                con.setRequestProperty("Content-type", "application/json");
                con.setDoOutput(true);

                JSONObject json = new JSONObject();

                json.put("nombre", nombre);
                json.put("nombreUsuario", nombreUsuario);
                json.put("passwordHash", passwordHash);
                json.put("email", email);
                json.put("genero", genero);
                json.put("fechaNacimiento",fechaNacimiento);



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
}
