package com.example.f1hub.fragments;



import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.fragment.app.Fragment;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import com.example.f1hub.R;
import com.example.f1hub.adapters.AdaptadorPublicaciones;
import com.example.f1hub.models.Publicaciones;

import java.util.ArrayList;
import java.util.List;

public class HomeFragment extends Fragment {

    private RecyclerView recyclerPosts;
    private AdaptadorPublicaciones adapter;
    private List<Publicaciones> listaPublicaciones;

    @Nullable
    @Override
    public View onCreateView(@NonNull LayoutInflater inflater, @Nullable ViewGroup container,
                             @Nullable Bundle savedInstanceState) {

        View view = inflater.inflate(R.layout.fragment_home, container, false);

        recyclerPosts = view.findViewById(R.id.recyclerPosts);
        recyclerPosts.setLayoutManager(new LinearLayoutManager(getContext()));


        listaPublicaciones = new ArrayList<>();

    listaPublicaciones.add(new Publicaciones("Ana", "Gran carrera de Verstappen", "Hace 1h"));
        listaPublicaciones.add(new Publicaciones("Luis", "Ferrari decepciona otra vez", "Hace 2h"));

        adapter = new AdaptadorPublicaciones(listaPublicaciones);
        recyclerPosts.setAdapter(adapter);

        return view;
    }
}
