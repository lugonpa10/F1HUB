package com.example.f1hub;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

public class RegistroPassword extends AppCompatActivity {
    EditText etContrasenha;
    EditText etRepetirContrasenha;

    Button btnConfirmar;

    @Override

    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);

        setContentView(R.layout.activity_registro_password);
        etContrasenha = findViewById(R.id.etPassword);
        etRepetirContrasenha = findViewById(R.id.etRepetirPassword);
        btnConfirmar = findViewById(R.id.btnConfirmar);
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });



        btnConfirmar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                String contrasenha = etContrasenha.getText().toString();
                String repetirContrasenha = etRepetirContrasenha.getText().toString();
                if (contrasenhaValida(contrasenha)) {
                    Toast.makeText(RegistroPassword.this, "Contraseña válida", Toast.LENGTH_SHORT).show();
                    Intent intent = new Intent(RegistroPassword.this,MainActivity.class);
                    startActivity(intent);
                } else if (!contrasenha.equals(repetirContrasenha)) {
                    Toast.makeText(RegistroPassword.this, "Las contraseñas no coinciden", Toast.LENGTH_SHORT).show();
                } else {
                    Toast.makeText(RegistroPassword.this,
                            "La contraseña debe tener:\n" +
                                    "• 10 caracteres\n" +
                                    "• 1 mayúscula\n" +
                                    "• 1 minúscula\n" +
                                    "• 1 número\n" +
                                    "• 1 carácter especial",
                            Toast.LENGTH_LONG).show();
                }
            }
        });
    }



    public static boolean contrasenhaValida(String contrasenha) {
        String requisitos = "^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[@$!%*?&#._-])[A-Za-z\\d@$!%*?&#._-]{10,}$";
        return contrasenha.matches(requisitos);
    }


}