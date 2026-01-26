package f1hub;

public class Usuarios {
    private int idUsuario;
    private String nombre;
    private String nombreUsuario;
    private String passwordHash;
    private String email;
    private String genero;
    private byte[] fotoPerfil;
    private Timestamp fechaCreacion;

    public Usuarios() {

    }

    public Usuarios(int idUsuario,String nombre,String nombreUsuario,String passwordHash,String email,String genero,byte[] fotoPerfil,Timestamp fechaCreacion) {
        this.idUsuario = idUsuario;
        this.nombre = nombre;
        this.nombreUsuario = nombreUsuario;
        this.passwordHash = passwordHash;
        this.email = email;
        this.genero = genero;
        this.fotoPerfil = fotoPerfil;
        this.fechaCreacion = fechaCreacion;
       
    }

    public void setIdUsuario(int idUsuario) {
        this.idUsuario = idUsuario;
    }

    public int getIdUsuario() {
        return idUsuario;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombreUsuario(String nombreUsuario) {
        this.nombreUsuario = nombreUsuario;
    }

    public String getNombreUsuario() {
        return nombreUsuario;
    }

    public void setPasswordHash(String passwordHash) {
        this.passwordHash = passwordHash;
    }

    public String getPasswordHash() {
        return passwordHash;
    }

    public void setEmail(String email) {
        this.email = email;
    }

    public String getEmail() {
        return email;
    }

    public void setGenero(String genero) {
        this.genero = genero;
    }

    public String getGenero() {
        return genero;
    }

    public void setFotoPerfil(byte[] fotoPerfil) {
        this.fotoPerfil = fotoPerfil;
    }

    public byte[] getFotoPerfil() {
        return fotoPerfil;
    }

    public void setFechaCreacion(Timestamp fechaCreacion) {
        this.fechaCreacion = fechaCreacion;
    }

    public Timestamp getFechaCreacion() {
        return fechaCreacion;
    }

}
