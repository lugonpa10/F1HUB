package com.example.f1hub.adapters;

import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ImageButton;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.recyclerview.widget.RecyclerView;

import com.example.f1hub.R;
import com.example.f1hub.models.Publicaciones;

import java.util.List;

public class AdaptadorPublicaciones
        extends RecyclerView.Adapter<AdaptadorPublicaciones.PostViewHolder> {

    private List<Publicaciones> listaPosts;
    private boolean mostrarBorrar;
    private OnBorrarListener borrarListener;

    public interface OnBorrarListener {
        void onBorrar(int idPublicacion, int position);
    }


    public AdaptadorPublicaciones(List<Publicaciones> listaPosts) {
        this.listaPosts = listaPosts;
        this.mostrarBorrar = false;
        this.borrarListener = null;
    }


    public AdaptadorPublicaciones(List<Publicaciones> listaPosts, boolean mostrarBorrar, OnBorrarListener listener) {
        this.listaPosts = listaPosts;
        this.mostrarBorrar = mostrarBorrar;
        this.borrarListener = listener;
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

        if (mostrarBorrar) {
            holder.btnBorrar.setVisibility(View.VISIBLE);
            holder.btnBorrar.setOnClickListener(v -> {
                if (borrarListener != null) {
                    borrarListener.onBorrar(post.getId(), position);
                }
            });
        } else {
            holder.btnBorrar.setVisibility(View.GONE);
        }
    }

    @Override
    public int getItemCount() {
        return listaPosts.size();
    }

    static class PostViewHolder extends RecyclerView.ViewHolder {

        TextView usuario, contenido, fecha;
        ImageButton btnBorrar;

        public PostViewHolder(@NonNull View itemView) {
            super(itemView);
            usuario = itemView.findViewById(R.id.txtUsuario);
            contenido = itemView.findViewById(R.id.txtContenido);
            fecha = itemView.findViewById(R.id.txtFecha);
            btnBorrar = itemView.findViewById(R.id.btnBorrarPublicacion);
        }
    }
}