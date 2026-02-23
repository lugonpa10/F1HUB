package com.example.f1hub.models;


public class Publicaciones {

    private int id;
    private String usuario;
    private String contenido;
    private String fecha;

    public Publicaciones() {

    }

    public Publicaciones( String usuario, String contenido, String fecha) {
        this.usuario = usuario;
        this.contenido = contenido;
        this.fecha = fecha;
    }

    public int getId() {return id;}

    public String getUsuario() {
        return usuario;
    }

    public String getContenido() {
        return contenido;
    }

    public String getFecha() {
        return fecha;
    }

    public void setId(int id) {this.id = id;}

    public void setContenido(String contenido) {
        this.contenido = contenido;
    }

    public void setFecha(String fecha) {
        this.fecha = fecha;
    }

    public void setUsuario(String usuario) {
        this.usuario = usuario;
    }
}