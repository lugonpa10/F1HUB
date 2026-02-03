package f1hub;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

import jakarta.ws.rs.Consumes;
import jakarta.ws.rs.FormParam;
import jakarta.ws.rs.GET;
import jakarta.ws.rs.PATCH;
import jakarta.ws.rs.POST;
import jakarta.ws.rs.Path;
import jakarta.ws.rs.QueryParam;
import jakarta.ws.rs.core.MediaType;
import jakarta.ws.rs.core.Response;
import org.mindrot.jbcrypt.BCrypt;

@Path("/usuarios")
public class ApiRest {

    private static final String URL = "jdbc:mariadb://sql.freedb.tech:3306/freedb_F1HUB";
    private static final String USER = "freedb_lugonpa_33";
    private static final String PASS = "GUbUrE5WdG8?eUB";

    @POST
    @Path("/registro")
    @Consumes(MediaType.APPLICATION_JSON)
    public Response insertarUsuario(Usuarios usuario) {

        try {
            Class.forName("org.mariadb.jdbc.Driver");

            String sql = "INSERT INTO Usuarios (nombre, apellidos,nombre_usuario,password_hash, email, genero, foto_perfil, fecha_nacimiento) VALUES (?, ?, ?, ?, ?, ?, ?,?)";

            try (Connection conexion = DriverManager.getConnection(URL, USER, PASS);
                    PreparedStatement ps = conexion.prepareStatement(sql)) {

                String password = usuario.getPasswordHash();
                String passwordEncriptada = BCrypt.hashpw(password, BCrypt.gensalt(10));

                ps.setString(1, usuario.getNombre());
                ps.setString(2, usuario.getApellidos());
                ps.setString(3, usuario.getNombreUsuario());
                ps.setString(4, passwordEncriptada);
                ps.setString(5, usuario.getEmail());
                ps.setString(6, usuario.getGenero());
                ps.setBytes(7, usuario.getFotoPerfil());
                ps.setDate(8, usuario.getFechaNacimiento());

                ps.executeUpdate();

                return Response.status(Response.Status.CREATED)
                        .entity("Usuario insertado correctamente")
                        .build();

            } catch (SQLException e) {
                e.printStackTrace();
                return Response.status(Response.Status.INTERNAL_SERVER_ERROR)
                        .entity("Error SQL")
                        .build();
            }

        } catch (ClassNotFoundException e) {
            return Response.status(Response.Status.INTERNAL_SERVER_ERROR)
                    .entity("No se encuentra el driver")
                    .build();
        }
    }

    @POST
    @Path("/inicioSesion")
    @Consumes(MediaType.APPLICATION_JSON)
    public Response validarUsuario(
            Usuarios u) {
        if (u.getNombreUsuario() == null || u.getPasswordHash() == null) {
            return Response.status(Response.Status.BAD_REQUEST).entity("Falta algun dato").build();
        }
        try {
            Class.forName("org.mariadb.jdbc.Driver");
            String sql = "Select password_hash from Usuarios where nombre_usuario  = ?";

            try (Connection conexion = DriverManager.getConnection(URL, USER, PASS);
                    PreparedStatement ps = conexion.prepareStatement(sql)) {

                ps.setString(1, u.getNombreUsuario());
                ResultSet rs = ps.executeQuery();
                if (!rs.next()) {
                    return Response.status(Response.Status.NOT_FOUND).entity("Usuario no encontrado").build();

                }

                String passwordHashBD = rs.getString("password_hash");

                if (BCrypt.checkpw(u.getPasswordHash(), passwordHashBD)) {
                    return Response.ok("Login correcto").build();
                } else {
                    return Response.status(Response.Status.UNAUTHORIZED)
                            .entity("Contraseña incorrecta")
                            .build();
                }

            } catch (SQLException e) {
                e.printStackTrace();
                return Response.status(Response.Status.INTERNAL_SERVER_ERROR)
                        .entity("Error SQL")
                        .build();
            }

        } catch (ClassNotFoundException e) {
            return Response.status(Response.Status.INTERNAL_SERVER_ERROR)
                    .entity("No se encuentra el driver")
                    .build();
        }

    }

    // @POST
    // @Path("/subirPublicacion")
    // @Consumes(MediaType.APPLICATION_JSON)
    // public Response subirPubli(Usuarios u){
    //     try{
    //             Class.forName("org.mariadb.jdbc.Driver");
    //             String sql =

    //     }catch(ClassNotFoundException e){
    //             return Response.status(Response.Status.INTERNAL_SERVER_ERROR)
    //                 .entity("No se encuentra el driver")
    //                 .build();
    //     }


    // }

}
