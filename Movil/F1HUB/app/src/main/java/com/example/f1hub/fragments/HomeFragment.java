package com.example.f1hub.fragments;


import android.content.Intent;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ImageButton;

import androidx.activity.result.ActivityResultLauncher;
import androidx.activity.result.contract.ActivityResultContracts;
import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.fragment.app.Fragment;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import com.example.f1hub.R;
import com.example.f1hub.activities.MainActivity;
import com.example.f1hub.activities.SubidaPublicaciones;
import com.example.f1hub.adapters.AdaptadorPublicaciones;
import com.example.f1hub.api.ApiRest;
import com.example.f1hub.models.Publicaciones;
import com.example.f1hub.models.Usuario;



import java.util.ArrayList;

import java.util.List;


public class HomeFragment extends Fragment {

    private RecyclerView recyclerPosts;
    private AdaptadorPublicaciones adapter;
    private List<Publicaciones> listaPublicaciones;

    private ActivityResultLauncher<Intent> publicacionLauncher;

    ImageButton imgBtnPost;
    ApiRest api = new ApiRest();

    @Nullable
    @Override
    public View onCreateView(@NonNull LayoutInflater inflater, @Nullable ViewGroup container,
                             @Nullable Bundle savedInstanceState) {


        View view = inflater.inflate(R.layout.fragment_home, container, false);

        recyclerPosts = view.findViewById(R.id.recyclerPosts);
        imgBtnPost = view.findViewById(R.id.imgPost);
        recyclerPosts.setLayoutManager(new LinearLayoutManager(getContext()));


        listaPublicaciones = new ArrayList<>();


        adapter = new AdaptadorPublicaciones(listaPublicaciones);
        recyclerPosts.setAdapter(adapter);
        imgBtnPost.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                MainActivity mainActivity = (MainActivity) getActivity();
                Usuario usuario = mainActivity.getUsuarioActual();
                Intent intent = new Intent(requireActivity(), SubidaPublicaciones.class);
                intent.putExtra("usuario", usuario);
                publicacionLauncher.launch(intent);


            }
        });

        cargarPublicaciones();

        return view;


    }




    @Override
    public void onCreate(@Nullable Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);

        publicacionLauncher = registerForActivityResult(
                new ActivityResultContracts.StartActivityForResult(),
                result -> {
                    if (result.getResultCode() == getActivity().RESULT_OK && result.getData() != null) {
                        cargarPublicaciones();

                    }
                }
        );
    }

    private void cargarPublicaciones() {
        api.obtenerTodasPublicaciones(lista -> {
            if (!isAdded()) return;
            requireActivity().runOnUiThread(() -> {
                listaPublicaciones.clear();
                listaPublicaciones.addAll(lista);
                adapter.notifyDataSetChanged();
            });
        });
    }
}



