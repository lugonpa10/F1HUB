package f1hub;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

import jakarta.ws.rs.Consumes;
import jakarta.ws.rs.GET;
import jakarta.ws.rs.POST;
import jakarta.ws.rs.Path;
import jakarta.ws.rs.core.MediaType;
import jakarta.ws.rs.core.Response;

@Path("/usuarios")
public class GestionaUsarios {
    private static final String URL = "jdbc:mariadb://sql.freedb.tech:3306/freedb_F1HUB";
    private static final String USER = "freedb_lugonpa_33";
    private static final String PASS = "GUbUrESWdG8?eUB";

    @Path("/prueba")
    @GET
    @Consumes({ MediaType.APPLICATION_JSON })
    public Response prueba() {
        try {
            Class.forName("org.mariadb.jdbc.Driver"); // solo una vez

            Connection conexion = null;
            Statement st = null;

            try {
                conexion = DriverManager.getConnection(URL, USER, PASS);
                st = conexion.createStatement();

                String consulta = "Select * from Usuarios";

                ResultSet rs =st.executeQuery(consulta);

                return Response.ok(rs).build();

            } catch (SQLException e) {
                e.printStackTrace(); // muestra el error real en el log
                return Response.status(Response.Status.INTERNAL_SERVER_ERROR)
                        .entity("Error SQL: " + e.getMessage())
                        .build();
            } finally {
                try {
                    if (st != null)
                        st.close();
                    if (conexion != null)
                        conexion.close();
                } catch (SQLException e) {
                    e.printStackTrace();
                    
                }
            }

        } catch (ClassNotFoundException e) {
            return null;
        }
    }

    @Path("/subir")
    @POST
    @Consumes({ MediaType.APPLICATION_JSON })
    public Response subirUsuario(Usuarios u) throws ClassNotFoundException {
        Class.forName("org.mariadb.jdbc.Driver"); // solo una vez

        Connection conexion = null;
        Statement st = null;

        try {
            conexion = DriverManager.getConnection(URL, USER, PASS);
            st = conexion.createStatement();

            String sql = "INSERT INTO Usuarios(nombre_usuario,password_hash) " + "VALUES ('" + u.getNombreUsuario()
                    + "','" + u.getPasswordHash() + "')";

            st.executeUpdate(sql);

            return Response.ok("Subido Correctamente").build();

        } catch (SQLException e) {
            e.printStackTrace(); // muestra el error real en el log
            return Response.status(Response.Status.INTERNAL_SERVER_ERROR)
                    .entity("Error SQL: " + e.getMessage())
                    .build();
        } finally {
            try {
                if (st != null)
                    st.close();
                if (conexion != null)
                    conexion.close();
            } catch (SQLException e) {
                e.printStackTrace();
            }
        }
    }

}
