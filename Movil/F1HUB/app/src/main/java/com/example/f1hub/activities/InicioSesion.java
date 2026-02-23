package com.example.f1hub.activities;

import android.content.Intent;
import android.graphics.Paint;
import android.os.Bundle;
import android.text.method.HideReturnsTransformationMethod;
import android.text.method.PasswordTransformationMethod;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;


import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

import com.example.f1hub.R;
import com.example.f1hub.api.ApiRest;
import com.example.f1hub.models.Usuario;
import com.google.android.material.imageview.ShapeableImageView;

public class InicioSesion extends AppCompatActivity {


    EditText etPassword;
    EditText etUsuario;

    Button btnIniciarSesion;

    TextView txtCrearCuenta;



    ApiRest api = new ApiRest();

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_inicio_sesion);
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });

        etPassword = findViewById(R.id.etContraseña);
        etUsuario = findViewById(R.id.etUsuario);
        btnIniciarSesion = findViewById(R.id.btnIniciarSesion);
        txtCrearCuenta = findViewById(R.id.txtCrearCuenta);
        txtCrearCuenta.setPaintFlags(txtCrearCuenta.getPaintFlags() | Paint.UNDERLINE_TEXT_FLAG);


        btnIniciarSesion.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                String usuario = etUsuario.getText().toString().trim();
                String contrasenha = etPassword.getText().toString().trim();

                api.inicioSesion(usuario, contrasenha, (success, userData) -> {
                    if (success && userData != null) {
                        try {
                            Log.i("LOGIN_DATA", userData.toString());
                            Usuario usuarioObj = new Usuario(
                                    userData.optInt("idUsuario", 0),
                                    userData.optString("nombre", ""),
                                    userData.optString("apellidos", ""),
                                    userData.optString("nombreUsuario", "Usuario"),
                                    userData.optString("email", ""),
                                    userData.optString("genero", ""),
                                  String.valueOf(userData.optLong("fechaNacimiento",0))
                            );


                            Intent intent = new Intent(InicioSesion.this, MainActivity.class);
                          intent.putExtra("usuario",usuarioObj);
                            startActivity(intent);
                            finish();

                        } catch (Exception e) {
                            Log.e("LOGIN_ERROR", "Error al procesar datos", e);
                        }
                    } else {
                        runOnUiThread(() -> {
                            Toast.makeText(InicioSesion.this, "Usuario o contraseña incorrectos", Toast.LENGTH_SHORT).show();
                        });
                    }
                });
            }
        });


        txtCrearCuenta.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                Intent intent = new Intent(InicioSesion.this, Registro.class);
                startActivity(intent);
            }
        });
    }


}