package f1hub;

import java.sql.Timestamp;

public class Publicaciones {

    private int idPubli;
    private Usuarios usuario;
    private String texto;
    private byte[] foto;
    private Timestamp fechaPublicacion;

    public Publicaciones() {

    }

    public Publicaciones(int idPubli, Usuarios usuario, String texto, byte[] foto, Timestamp fechaPublicacion) {
        this.idPubli = idPubli;
        this.usuario = usuario;
        this.texto = texto;
        this.foto = foto;
        this.fechaPublicacion = fechaPublicacion;
    }

    public void setIdPubli(int idPubli) {
        this.idPubli = idPubli;
    }

    public int getIdPubli() {
        return idPubli;
    }

    public void setUsuario(Usuarios usuario) {
        usuario = usuario;
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

    public void setFoto(byte[] foto) {
        this.foto = foto;
    }

    public byte[] getFoto() {
        return foto;
    }

    public void setFechaPublicacion(Timestamp fechaPublicacion) {
        this.fechaPublicacion = fechaPublicacion;
    }

    public Timestamp getFechaPublicacion() {
        return fechaPublicacion;
    }

}
