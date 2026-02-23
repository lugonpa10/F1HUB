package com.example.f1hub.models;

import android.os.Parcelable;

import java.io.Serializable;

public class Usuario implements Serializable {
    int id;
    private String nombre;
    private String apellidos;
    private String nombreUsuario;
    private String email;
    private String genero;
    private String fechaNacimiento;


    public Usuario() {
    }


    public Usuario(int id,String nombre, String apellidos,
                   String nombreUsuario, String email, String genero, String fechaNacimiento) {

        this.id = id;
        this.nombre = nombre;
        this.apellidos = apellidos;
        this.nombreUsuario = nombreUsuario;
        this.email = email;
        this.genero = genero;
        this.fechaNacimiento = fechaNacimiento;
    }

    public int getId(){return id;}

    public String getNombre() {
        return nombre;
    }

    public String getApellidos() {
        return apellidos;
    }

    public String getNombreUsuario() {
        return nombreUsuario;
    }

    public String getEmail() {
        return email;
    }

    public String getGenero() {
        return genero;
    }

    public String getFechaNacimiento() {
        return fechaNacimiento;
    }



    public void setId(int id){this.id = id;}

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public void setApellidos(String apellidos) {
        this.apellidos = apellidos;
    }

    public void setNombreUsuario(String nombreUsuario) {
        this.nombreUsuario = nombreUsuario;
    }

    public void setEmail(String email) {
        this.email = email;
    }

    public void setGenero(String genero) {
        this.genero = genero;
    }

    public void setFechaNacimiento(String fechaNacimiento) {
        this.fechaNacimiento = fechaNacimiento;
    }
}
