package com.example.f1hub.activities;

import android.os.Bundle;
import android.view.MenuItem;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;

import com.example.f1hub.R;
import com.example.f1hub.fragments.HomeFragment;
import com.example.f1hub.fragments.MessagesFragment;
import com.example.f1hub.fragments.NotificationsFragment;
import com.example.f1hub.models.Usuario;
import com.google.android.material.badge.BadgeDrawable;
import com.google.android.material.bottomnavigation.BottomNavigationView;
import com.google.android.material.navigation.NavigationBarView;

public class MainActivity extends AppCompatActivity {
    BottomNavigationView bottomNavigationView;

    private Usuario usuarioActual;

    HomeFragment homeFragment = new HomeFragment();
    MessagesFragment messagesFragment = new MessagesFragment();
    NotificationsFragment notificationsFragment = new NotificationsFragment();

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        usuarioActual = (Usuario) getIntent().getSerializableExtra("usuario");
        bottomNavigationView = findViewById(R.id.bottom_navigation);
        getSupportFragmentManager().beginTransaction().replace(R.id.container, homeFragment).commit();
        BadgeDrawable badgeDrawable = bottomNavigationView.getOrCreateBadge(R.id.notification);
        badgeDrawable.setVisible(true);
        badgeDrawable.setNumber(3);
        bottomNavigationView.setOnItemSelectedListener(new NavigationBarView.OnItemSelectedListener() {

            @Override
            public boolean onNavigationItemSelected(@NonNull MenuItem item) {
                int id = item.getItemId();

                if (id == R.id.home) {
                    getSupportFragmentManager()
                            .beginTransaction()
                            .replace(R.id.container, homeFragment)
                            .commit();
                    return true;

                } else if (id == R.id.notification) {
                    getSupportFragmentManager()
                            .beginTransaction()
                            .replace(R.id.container, notificationsFragment)
                            .commit();
                    return true;

                } else if (id == R.id.message) {
                    getSupportFragmentManager()
                            .beginTransaction()
                            .replace(R.id.container, messagesFragment)
                            .commit();
                    return true;
                } else if (id == R.id.perfil) {
                    getSupportFragmentManager()
                            .beginTransaction()
                            .replace(R.id.container, messagesFragment)
                            .commit();
                    return true;
                }

                return false;
            }

        });


    }
    public Usuario getUsuarioActual(){
        return usuarioActual;
    }
}