package com.example.f1hub.fragments;

import android.content.Intent;
import android.os.Bundle;

import androidx.fragment.app.Fragment;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import android.util.Log;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.TextView;

import com.example.f1hub.R;
import com.example.f1hub.activities.EditarPerfil;
import com.example.f1hub.activities.MainActivity;
import com.example.f1hub.adapters.AdaptadorPublicaciones;
import com.example.f1hub.api.ApiRest;
import com.example.f1hub.models.Publicaciones;
import com.example.f1hub.models.Usuario;
import com.google.android.material.button.MaterialButton;
import com.google.android.material.imageview.ShapeableImageView;

import java.util.ArrayList;
import java.util.List;

public class PerfilFragment extends Fragment {

    private RecyclerView recyclerPerfilPublicaciones;
    private AdaptadorPublicaciones adapter;
    private List<Publicaciones> listaPublicaciones;
    private TextView tvNombreUsuario;
    private ShapeableImageView imgFotoPerfil;
    private MaterialButton btnEditarPerfil;
    private Usuario usuario;

    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {

        View view = inflater.inflate(R.layout.fragment_perfil, container, false);
        tvNombreUsuario = view.findViewById(R.id.tvNombreUsuario);
        imgFotoPerfil = view.findViewById(R.id.imgFotoPerfil);
        btnEditarPerfil = view.findViewById(R.id.btnEditarPerfil);
        recyclerPerfilPublicaciones = view.findViewById(R.id.recyclerPerfilPublicaciones);
        recyclerPerfilPublicaciones.setLayoutManager(new LinearLayoutManager(getContext()));

        listaPublicaciones = new ArrayList<>();
        adapter = new AdaptadorPublicaciones(listaPublicaciones, true, (idPublicacion, position) -> {
            Log.i("BORRAR", "Id publicacion: " + idPublicacion);
            new androidx.appcompat.app.AlertDialog.Builder(requireContext())
                    .setMessage("¿Eliminar esta publicación?")
                    .setPositiveButton("Eliminar", (d, w) -> {
                        ApiRest api = new ApiRest();
                        api.eliminarPublicacion(idPublicacion, success -> {
                            requireActivity().runOnUiThread(() -> {
                                if (success) {
                                    cargarPublicaciones(usuario.getId(), usuario.getNombreUsuario());
                                } else {
                                    android.widget.Toast.makeText(getContext(), "Error al eliminar", android.widget.Toast.LENGTH_SHORT).show();
                                }
                            });
                        });
                    })
                    .setNegativeButton("Cancelar", null)
                    .show();
        });
        recyclerPerfilPublicaciones.setAdapter(adapter);

        MainActivity mainActivity = (MainActivity) getActivity();
        usuario = mainActivity.getUsuarioActual();
        Log.i("PERFIL", "Usuario: " + (usuario == null ? "NULL" : usuario.getNombreUsuario()));


        tvNombreUsuario.setText("@" + usuario.getNombreUsuario());


        cargarPublicaciones(usuario.getId(), usuario.getNombreUsuario());




        usuario = mainActivity.getUsuarioActual();

        btnEditarPerfil.setOnClickListener(v -> {
            Intent intent = new Intent(getActivity(), EditarPerfil.class);
            intent.putExtra("usuario", usuario);
            startActivity(intent);
        });

        return view;
    }

    private void cargarPublicaciones(int idUsuario,String nombreUsuario) {
        ApiRest api = new ApiRest();
        api.obtenerPublicacionesUsuario(idUsuario, nombreUsuario,lista -> {
            requireActivity().runOnUiThread(() -> {
                listaPublicaciones.clear();
                listaPublicaciones.addAll(lista);
                adapter.notifyDataSetChanged();
            });
        });
    }


}