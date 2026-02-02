package com.example.f1hub.adapters;

import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.recyclerview.widget.RecyclerView;

import com.example.f1hub.R;
import com.example.f1hub.models.Publicaciones;

import java.util.List;

public class AdaptadorPublicaciones
        extends RecyclerView.Adapter<AdaptadorPublicaciones.PostViewHolder> {

    private List<Publicaciones> listaPosts;

    // 🔹 CONSTRUCTOR CORRECTO
    public AdaptadorPublicaciones(List<Publicaciones> listaPosts) {
        this.listaPosts = listaPosts;
    }

    @NonNull
    @Override
    public PostViewHolder onCreateViewHolder(@NonNull ViewGroup parent, int viewType) {
        View view = LayoutInflater.from(parent.getContext())
                .inflate(R.layout.activity_publicaciones, parent, false);
        return new PostViewHolder(view);
    }

    @Override
    public void onBindViewHolder(@NonNull PostViewHolder holder, int position) {
        Publicaciones post = listaPosts.get(position);
        holder.usuario.setText(post.getUsuario());
        holder.contenido.setText(post.getContenido());
        holder.fecha.setText(post.getFecha());
    }

    @Override
    public int getItemCount() {
        return listaPosts.size();
    }

    static class PostViewHolder extends RecyclerView.ViewHolder {

        TextView usuario, contenido, fecha;

        public PostViewHolder(@NonNull View itemView) {
            super(itemView);
            usuario = itemView.findViewById(R.id.txtUsuario);
            contenido = itemView.findViewById(R.id.txtContenido);
            fecha = itemView.findViewById(R.id.txtFecha);
        }
    }
}
