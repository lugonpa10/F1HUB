package com.example.f1hub;

import android.os.Bundle;
import android.view.MenuItem;
import android.widget.Toolbar;

import androidx.activity.EdgeToEdge;
import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

import com.google.android.material.badge.BadgeDrawable;
import com.google.android.material.bottomnavigation.BottomNavigationView;
import com.google.android.material.navigation.NavigationBarView;

public class MainActivity extends AppCompatActivity {
BottomNavigationView bottomNavigationView;

HomeFragment homeFragment = new HomeFragment();
MessagesFragment messagesFragment = new MessagesFragment();
NotificationsFragment notificationsFragment = new NotificationsFragment();

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
bottomNavigationView = findViewById(R.id.bottom_navigation);
getSupportFragmentManager().beginTransaction().replace(R.id.container,homeFragment).commit();
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
}