package f1hub;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;

import jakarta.ws.rs.Consumes;
import jakarta.ws.rs.DELETE;
import jakarta.ws.rs.GET;
import jakarta.ws.rs.POST;
import jakarta.ws.rs.Path;
import jakarta.ws.rs.PathParam;
import jakarta.ws.rs.Produces;
import jakarta.ws.rs.core.MediaType;
import jakarta.ws.rs.core.Response;

@Path("/publicaciones")
public class ApiRestPublicaciones {
    private static final String URL = "jdbc:mariadb://sql.freedb.tech:3306/freedb_F1HUB";
    private static final String USER = "freedb_lugonpa_33";
    private static final String PASS = "GUbUrE5WdG8?eUB";

    @POST
    @Path("/subir")
    @Consumes(MediaType.APPLICATION_JSON)
    @Produces(MediaType.APPLICATION_JSON)
    public Response crearPublicacion(Publicaciones p) {
        try {
            Class.forName("org.mariadb.jdbc.Driver");
            String sql = "Insert into Publicaciones (id_Usuario,texto) VALUES (?,?)";
            try (Connection conexion = DriverManager.getConnection(URL, USER, PASS);
                    PreparedStatement ps = conexion.prepareStatement(sql)) {

                ps.setInt(1, p.getUsuario().getIdUsuario());
                ps.setString(2, p.getTexto());
                ps.executeUpdate();
                return Response.ok("Publicacion subida").build();

            } catch (SQLException e) {
                e.printStackTrace();
                return Response.status(Response.Status.INTERNAL_SERVER_ERROR).entity("Error Sql").build();

            }
        } catch (ClassNotFoundException e) {
            return Response.status(Response.Status.INTERNAL_SERVER_ERROR)
                    .entity("No se encuentra el driver")
                    .build();
        }
    }

    @GET
    @Path("/todas")
    @Produces(MediaType.APPLICATION_JSON)
    public Response obtenerTodas() {
        try {
            Class.forName("org.mariadb.jdbc.Driver");
            String sql = "SELECT p.id_publicacion, u.nombre_usuario, p.texto, p.fecha_publicacion FROM Publicaciones p JOIN Usuarios u ON p.id_Usuario = u.Id_Usuario ORDER BY p.fecha_publicacion DESC";
            try (Connection conexion = DriverManager.getConnection(URL, USER, PASS);
                    PreparedStatement ps = conexion.prepareStatement(sql)) {
                ResultSet rs = ps.executeQuery();
                ArrayList<Publicaciones> lista = new ArrayList<>();
                while (rs.next()) {
                    Publicaciones p = new Publicaciones();
                    Usuarios u = new Usuarios();
                    u.setNombreUsuario(rs.getString("nombre_usuario"));
                    p.setIdPubli(rs.getInt("id_publicacion"));
                    p.setUsuario(u);
                    p.setTexto(rs.getString("texto"));
                    p.setFechaPublicacion(rs.getTimestamp("fecha_publicacion"));
                    lista.add(p);
                }
                return Response.ok(lista).build();
            } catch (SQLException e) {
                return Response.status(Response.Status.INTERNAL_SERVER_ERROR).build();
            }
        } catch (ClassNotFoundException e) {
            return Response.status(Response.Status.INTERNAL_SERVER_ERROR).build();
        }
    }

    @GET
    @Path("/{idUsuario}")
    @Produces(MediaType.APPLICATION_JSON)
    public Response obtenerPublicaciones(@PathParam("idUsuario") int idUsuario) {
        try {
            Class.forName("org.mariadb.jdbc.Driver");
            String sql = "SELECT id_publicacion, texto, fecha_publicacion FROM Publicaciones WHERE id_Usuario = ? ORDER BY fecha_publicacion DESC";
            try (Connection conexion = DriverManager.getConnection(URL, USER, PASS);
                    PreparedStatement ps = conexion.prepareStatement(sql)) {
                ps.setInt(1, idUsuario);
                ResultSet rs = ps.executeQuery();
                ArrayList<Publicaciones> lista = new ArrayList<>();
                while (rs.next()) {
                    Publicaciones p = new Publicaciones();
                    p.setIdPubli(rs.getInt("id_publicacion"));
                    p.setTexto(rs.getString("texto"));
                    p.setFechaPublicacion(rs.getTimestamp("fecha_publicacion"));
                    lista.add(p);
                }
                return Response.ok(lista).build();
            } catch (SQLException e) {
                return Response.status(Response.Status.INTERNAL_SERVER_ERROR).build();
            }
        } catch (ClassNotFoundException e) {
            return Response.status(Response.Status.INTERNAL_SERVER_ERROR).build();
        }
    }

    @DELETE
    @Path("/{id}")
    @Produces(MediaType.APPLICATION_JSON)
    public Response eliminarPublicacion(@PathParam("id") int id) {
        try {
            Class.forName("org.mariadb.jdbc.Driver");
            String sql = "DELETE FROM Publicaciones WHERE id_publicacion = ?";
            try (Connection conexion = DriverManager.getConnection(URL, USER, PASS);
                    PreparedStatement ps = conexion.prepareStatement(sql)) {
                ps.setInt(1, id);
                ps.executeUpdate();
                return Response.ok("{\"mensaje\": \"Publicacion eliminada\"}").type(MediaType.APPLICATION_JSON).build();
            } catch (SQLException e) {
                return Response.status(Response.Status.INTERNAL_SERVER_ERROR).build();
            }
        } catch (ClassNotFoundException e) {
            return Response.status(Response.Status.INTERNAL_SERVER_ERROR).build();
        }
    }

}
