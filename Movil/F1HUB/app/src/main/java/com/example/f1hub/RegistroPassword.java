package com.example.f1hub;

import android.os.Bundle;
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

    @Override

    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        etContrasenha = findViewById(R.id.etPassword);
        etRepetirContrasenha = findViewById(R.id.etRepetirPassword);
        setContentView(R.layout.activity_registro_password);
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });

        String contrasenha = etContrasenha.getText().toString();
        String repetirContrasenha = etRepetirContrasenha.getText().toString();
        if (contrasenhaValida(contrasenha)) {
            Toast.makeText(this,"Contraseña válida",Toast.LENGTH_SHORT).show();
        } else if (contrasenha != repetirContrasenha) {
            Toast.makeText(this,"Las contraseñas no coinciden",Toast.LENGTH_SHORT).show();
        } else {
            Toast.makeText(this,
                    "La contraseña debe tener:\n" +
                            "• 10 caracteres\n" +
                            "• 1 mayúscula\n" +
                            "• 1 minúscula\n" +
                            "• 1 número\n" +
                            "• 1 carácter especial",
                    Toast.LENGTH_LONG).show();
        }
    }

    public static boolean contrasenhaValida(String contrasenha) {
        String requisitos = "^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[@$!%*?&#._-])[A-Za-z\\d@$!%*?&#._-]{10,}$";
        return contrasenha.matches(requisitos);
    }


}