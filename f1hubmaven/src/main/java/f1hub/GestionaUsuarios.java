package f1hub;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.SQLException;
import java.sql.Statement;

import jakarta.ws.rs.Consumes;
import jakarta.ws.rs.POST;
import jakarta.ws.rs.Path;
import jakarta.ws.rs.core.MediaType;
import jakarta.ws.rs.core.Response;

@Path("/usuarios")
public class GestionaUsuarios {

    private static final String URL = "jdbc:mariadb://sql.freedb.tech:3306/freedb_F1HUB";
    private static final String USER = "freedb_lugonpa_33";
    private static final String PASS = "GUbUrE5WdG8?eUB";

    @POST
    @Path("/registro")
    @Consumes(MediaType.APPLICATION_JSON)
    public Response insertarUsuario(Usuarios usuario) {

        try {
            Class.forName("org.mariadb.jdbc.Driver");

           String sql = "INSERT INTO Usuarios (nombre, nombre_usuario, password_hash, email, genero, foto_perfil, fecha_nacimiento) VALUES (?, ?, ?, ?, ?, ?, ?)";


            try (Connection conexion = DriverManager.getConnection(URL, USER, PASS);
                    PreparedStatement ps = conexion.prepareStatement(sql)) {

                ps.setString(1, usuario.getNombre());
                ps.setString(2, usuario.getNombreUsuario());
                ps.setString(3, usuario.getPasswordHash());
                ps.setString(4, usuario.getEmail());
                ps.setString(5, usuario.getGenero());
                ps.setBytes(6, usuario.getFotoPerfil());
                ps.setDate(7, usuario.getFechaNacimiento());

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

}
