package com.example.f1hub.activities;

import android.app.DatePickerDialog;
import android.os.Bundle;
import android.widget.Toast;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.appcompat.widget.Toolbar;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

import com.example.f1hub.R;
import com.example.f1hub.api.ApiRest;
import com.example.f1hub.models.Usuario;
import com.google.android.material.button.MaterialButton;
import com.google.android.material.textfield.TextInputEditText;

import java.text.SimpleDateFormat;
import java.util.Calendar;
import java.util.Locale;

public class EditarPerfil extends AppCompatActivity {

    private TextInputEditText etNombre, etApellidos, etEmail;
    private MaterialButton btnGuardarCambios;
    private Toolbar toolbarEditar;
    private Usuario usuario;
    private MaterialButton btnFechaNacimiento;
    private String fechaSeleccionada = "";

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_editar_perfil);


        toolbarEditar = findViewById(R.id.toolbarEditar);
        setSupportActionBar(toolbarEditar);
        if (getSupportActionBar() != null) {
            getSupportActionBar().setDisplayHomeAsUpEnabled(true);
        }
        toolbarEditar.setNavigationOnClickListener(v -> finish());
        usuario = (Usuario) getIntent().getSerializableExtra("usuario");


        etNombre = findViewById(R.id.etNombre);
        etApellidos = findViewById(R.id.etApellidos);
        etEmail = findViewById(R.id.etEmail);
        btnGuardarCambios = findViewById(R.id.btnGuardarCambios);


        etNombre.setText(usuario.getNombre());
        etApellidos.setText(usuario.getApellidos());
        etEmail.setText(usuario.getEmail());

        btnFechaNacimiento = findViewById(R.id.btnFechaNacimiento);

        if (usuario.getFechaNacimiento() != null && !usuario.getFechaNacimiento().isEmpty()) {
            fechaSeleccionada = usuario.getFechaNacimiento();

            try {
                long timestamp = Long.parseLong(usuario.getFechaNacimiento());
                SimpleDateFormat sdf = new SimpleDateFormat("dd/MM/yyyy", Locale.getDefault());
                btnFechaNacimiento.setText(sdf.format(new java.util.Date(timestamp)));
            } catch (Exception e) {
                btnFechaNacimiento.setText(usuario.getFechaNacimiento());
            }
        }

        btnFechaNacimiento.setOnClickListener(v -> {
            Calendar calendar = Calendar.getInstance();
            int year = calendar.get(Calendar.YEAR);
            int month = calendar.get(Calendar.MONTH);
            int day = calendar.get(Calendar.DAY_OF_MONTH);

            DatePickerDialog datePicker = new DatePickerDialog(this, (view, y, m, d) -> {
                Calendar cal = Calendar.getInstance();
                cal.set(y, m, d, 0, 0, 0);
                cal.set(Calendar.MILLISECOND, 0);
                fechaSeleccionada = String.valueOf(cal.getTimeInMillis());
                btnFechaNacimiento.setText(d + "/" + (m + 1) + "/" + y);
            }, year, month, day);
            datePicker.show();
        });

        btnGuardarCambios.setOnClickListener(v -> {
            String nombre = etNombre.getText().toString().trim();
            String apellidos = etApellidos.getText().toString().trim();
            String email = etEmail.getText().toString().trim();

            if (nombre.isEmpty() || apellidos.isEmpty() || email.isEmpty()) {
                Toast.makeText(this, "Rellena todos los campos", Toast.LENGTH_SHORT).show();
                return;
            }

            ApiRest api = new ApiRest();
            api.editarUsuario(usuario.getNombreUsuario(), nombre, apellidos, email, fechaSeleccionada,success -> {
                runOnUiThread(() -> {
                    if (success) {
                        Toast.makeText(this, "Perfil actualizado", Toast.LENGTH_SHORT).show();
                        finish();
                    } else {
                        Toast.makeText(this, "Error al actualizar", Toast.LENGTH_SHORT).show();
                    }
                });
            });
        });
    }
}