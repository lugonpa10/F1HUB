package f1hub;

import java.sql.Timestamp;

public class Publicaciones {

    private int idPubli;
    private Usuarios usuario;
    private String texto;
    private Timestamp fechaPublicacion;

    public Publicaciones() {

    }

    public Publicaciones(int idPubli, Usuarios usuario, String texto, Timestamp fechaPublicacion) {
        this.idPubli = idPubli;
        this.usuario = usuario;
        this.texto = texto;

        this.fechaPublicacion = fechaPublicacion;
    }

    public void setIdPubli(int idPubli) {
        this.idPubli = idPubli;
    }

    public int getIdPubli() {
        return idPubli;
    }

    public void setUsuario(Usuarios usuario) {
        this.usuario = usuario;
    }

    public Usuarios getUsuario() {
        return usuario;
    }

    public void setTexto(String texto) {
        this.texto = texto;
    }

    public String getTexto() {
        return texto;
    }
    
    public void setFechaPublicacion(Timestamp fechaPublicacion) {
        this.fechaPublicacion = fechaPublicacion;
    }

    public Timestamp getFechaPublicacion() {
        return fechaPublicacion;
    }

}
