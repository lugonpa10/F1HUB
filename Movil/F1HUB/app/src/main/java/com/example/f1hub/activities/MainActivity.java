package com.example.f1hub.activities;

import android.os.Bundle;
import android.util.Log;
import android.view.MenuItem;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;

import com.example.f1hub.R;
import com.example.f1hub.fragments.HomeFragment;
import com.example.f1hub.fragments.PerfilFragment;
import com.example.f1hub.fragments.SalirFragment;
import com.example.f1hub.models.Usuario;
import com.google.android.material.badge.BadgeDrawable;
import com.google.android.material.bottomnavigation.BottomNavigationView;
import com.google.android.material.navigation.NavigationBarView;

public class MainActivity extends AppCompatActivity {
     public BottomNavigationView bottomNavigationView;

    private Usuario usuarioActual;


  PerfilFragment perfilFragment = new PerfilFragment();

  SalirFragment salirFragment = new SalirFragment();

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        usuarioActual = (Usuario) getIntent().getSerializableExtra("usuario");
        Log.i("MAIN", "Usuario recibido: " + (usuarioActual == null ? "NULL" : usuarioActual.getNombreUsuario()));
        bottomNavigationView = findViewById(R.id.bottom_navigation);
        getSupportFragmentManager().beginTransaction().replace(R.id.container, new HomeFragment()).commit();

        bottomNavigationView.setOnItemSelectedListener(new NavigationBarView.OnItemSelectedListener() {

            @Override
            public boolean onNavigationItemSelected(@NonNull MenuItem item) {
                int id = item.getItemId();

                if (id == R.id.home) {
                    getSupportFragmentManager()
                            .beginTransaction()
                            .replace(R.id.container, new HomeFragment())
                            .commit();
                    return true;


                } else if (id == R.id.perfil) {
                    getSupportFragmentManager()
                            .beginTransaction()
                            .replace(R.id.container, perfilFragment)
                            .commit();
                    return true;
                } else if (id == R.id.salir) {
                    getSupportFragmentManager()
                            .beginTransaction()
                            .replace(R.id.container,salirFragment)
                            .commit();
                    return true;


                }

                return false;
            }

        });


    }

    public Usuario getUsuarioActual() {
        return usuarioActual;
    }

}