package com.example.f1hub;

import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.Spinner;
import android.widget.Toast;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;



public class Registro extends AppCompatActivity {
    boolean muestra=false;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_registro);
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
    }
}