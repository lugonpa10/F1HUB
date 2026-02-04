package com.example.f1hub.activities;

import android.content.Intent;
import android.os.Bundle;
import android.text.Editable;
import android.text.TextWatcher;
import android.view.Menu;
import android.view.MenuItem;
import android.view.ViewStructure;
import android.widget.EditText;
import android.widget.ImageView;


import androidx.activity.EdgeToEdge;

import androidx.appcompat.app.AlertDialog;
import androidx.appcompat.app.AppCompatActivity;
import androidx.appcompat.widget.Toolbar;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

import com.example.f1hub.R;
import com.example.f1hub.fragments.HomeFragment;
import com.example.f1hub.models.Usuario;

public class SubidaPublicaciones extends AppCompatActivity {
    Toolbar toolbarPublicaciones;
    EditText etSubirPublicacion;

    private Usuario usuario;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_subida_publicaciones);
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });
        usuario = (Usuario) getIntent().getSerializableExtra("usuario");

        toolbarPublicaciones = findViewById(R.id.toolbarPublicaciones);
        setSupportActionBar(toolbarPublicaciones);
        etSubirPublicacion = findViewById(R.id.etSubirPublicacion);
        etSubirPublicacion.addTextChangedListener(new TextWatcher() {
            @Override
            public void afterTextChanged(Editable s) {

            }

            @Override
            public void beforeTextChanged(CharSequence s, int start, int count, int after) {

            }

            @Override
            public void onTextChanged(CharSequence s, int start, int before, int count) {
                textoObsceno();
            }
        });


        if (getSupportActionBar() != null) {
            getSupportActionBar().setDisplayHomeAsUpEnabled(true);
            getSupportActionBar().setDisplayShowHomeEnabled(true);
            getSupportActionBar().setTitle("Nueva Publicación");
        }


    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        getMenuInflater().inflate(R.menu.menu_subir_publi, menu);
        return true;
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        if (item.getItemId() == android.R.id.home) {
            onBackPressed();
            return true;
        } else if (item.getItemId() == R.id.publicar) {
            String post = etSubirPublicacion.getText().toString();

            if (post.isEmpty()){
                new AlertDialog.Builder(SubidaPublicaciones.this)
                        .setMessage("Necesitas escribir algo")
                        .setPositiveButton("Aceptar",null)
                        .show();
            }else {

                String nombreUsuario = usuario.getNombreUsuario();


                Intent resultIntent = new Intent();
                resultIntent.putExtra("post",post);
                resultIntent.putExtra("nombre",nombreUsuario);
                setResult(RESULT_OK,resultIntent);
                new AlertDialog.Builder(SubidaPublicaciones.this)
                        .setMessage("Publicacion Subida")
                        .setPositiveButton("Aceptar",null)
                        .show();



            }


            Intent intent = new Intent(SubidaPublicaciones.this, HomeFragment.class);
            intent.putExtra("post",post);
        }
        return super.onOptionsItemSelected(item);
    }

    public void textoObsceno() {

        ImageView ferNormal = findViewById(R.id.imgFerContento);
        String texto = etSubirPublicacion.getText().toString();
        boolean insultos = false;

        if (texto.contains("maricon") || texto.contains("tonto") || texto.contains("imbecil")) {
            insultos = true;
        }

        if (insultos) {
            ferNormal.setImageResource(R.drawable.ferangry);

        } else {
            ferNormal.setImageResource(R.drawable.fer);
        }


    }


}