package com.example.f1hub;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Spinner;
import android.widget.TextView;
import android.widget.Toast;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;



public class Registro extends AppCompatActivity {
    boolean muestra=false;
    boolean datosCorrectos = true;
    Button btnSiguiente;
    EditText etNombre,etApellidos,etFechaNacimiento,etCorreo,etNombreUsuario;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_registro);
        btnSiguiente = findViewById(R.id.btnSiguiente);
        etNombre = findViewById(R.id.etNombre);
        etApellidos = findViewById(R.id.etApellidos);
        etFechaNacimiento = findViewById(R.id.etFecha);
        etCorreo = findViewById(R.id.etCorreo);
        etNombreUsuario = findViewById(R.id.etNombreUsuario);

        final String[] provincias=getResources().getStringArray(R.array.generos);
        Spinner spinner=findViewById(R.id.spinner);
        ArrayAdapter<String> adapter=new ArrayAdapter<String>(this,
                android.R.layout.simple_spinner_item, provincias);
        spinner.setAdapter(adapter);
        spinner.setOnItemSelectedListener(new AdapterView.OnItemSelectedListener() {
            @Override
            public void onItemSelected(AdapterView<?> adapterView, View view,
                                       int i, long l) {
// Se usa la variable booleana para impedir que muestre el resultado
// seleccionado por defecto cuando se accede al activity. Solo mostramos
// cuando seleccionamos una opción.

                TextView textView = (TextView) view;
                textView.setTextColor(getResources().getColor(R.color.rojo));
                if (!muestra) muestra=true;
                else {
                    Toast.makeText(getApplicationContext(), "Has selecionado: " +
                                    adapterView.getItemAtPosition(i).toString(),
                            Toast.LENGTH_SHORT).show();
                    setTitle(adapterView.getItemAtPosition(i).toString());
                }


            }


            // Se ejecuta cuando se pulsa fuera del Spinner: cuandono se selecciona nada
            @Override
            public void onNothingSelected(AdapterView<?> adapterView) {
            }

        });
        btnSiguiente.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                String nombre = etNombre.getText().toString();
                String apellidos = etApellidos.getText().toString();
                String fechaNacimiento = etFechaNacimiento.getText().toString();
                String correo = etCorreo.getText().toString();
                String nombreUsuario = etNombreUsuario.getText().toString();

                if (nombre.isEmpty() || apellidos.isEmpty()  || fechaNacimiento.isEmpty() ||  correo.isEmpty() ||  nombreUsuario.isEmpty()){
                    Toast.makeText(Registro.this,"Todos los campos son obligatorios",Toast.LENGTH_SHORT).show();

                } else if ( nombre.equals("Nombre") || apellidos.equals("Apellidos") || fechaNacimiento.equals("Fecha") || correo.equals("Correo") || nombreUsuario.equals("Mote")){
                    Toast.makeText(Registro.this,"Datos no validos",Toast.LENGTH_SHORT).show();
                }else {
                    Intent intent = new Intent(Registro.this,RegistroPassword.class);
                    startActivity(intent);
                }

            }
        });


    }
}