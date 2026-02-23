package com.example.f1hub.fragments;

import android.content.Intent;
import android.os.Bundle;

import androidx.fragment.app.Fragment;

import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;

import com.example.f1hub.R;
import com.example.f1hub.activities.InicioSesion;
import com.example.f1hub.activities.MainActivity;


public class SalirFragment extends Fragment {



    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {


        new androidx.appcompat.app.AlertDialog.Builder(requireContext())
                .setMessage("¿Cerrar sesión?")
                .setPositiveButton("Sí", (d, w) -> {
                    Intent intent = new Intent(requireActivity(), InicioSesion.class);
                    intent.setFlags(Intent.FLAG_ACTIVITY_NEW_TASK | Intent.FLAG_ACTIVITY_CLEAR_TASK);
                    startActivity(intent);
                })
                .setNegativeButton("Cancelar", (d, w) -> {
                    MainActivity mainActivity = (MainActivity) requireActivity();
                    mainActivity.getSupportFragmentManager()
                            .beginTransaction()
                            .replace(R.id.container, new HomeFragment())
                            .commit();
                    mainActivity.bottomNavigationView.setSelectedItemId(R.id.home);
                })
                .show();
        return inflater.inflate(R.layout.fragment_salir, container, false);
    }
}