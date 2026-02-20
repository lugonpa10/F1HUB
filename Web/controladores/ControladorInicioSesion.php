 <?php
require_once 'modelos/Usuario.php';

class ControladorInicioSesion{

    public function IniciarSesion(){

        if (session_status() === PHP_SESSION_NONE) {
            session_start();
        }


        if($_SERVER['REQUEST_METHOD'] == 'POST'){
            $nombreUsuario = $_POST['nombreUsuario'];
            $password = $_POST['password'];

            $usuarioModel = new Usuario();
            $resultado = $usuarioModel ->login($nombreUsuario,$password);

            if($resultado && isset($resultado->nombreUsuario)){
                $_SESSION['usuario'] = $resultado;

            header('Location: index.php?action=Muro');
            exit();
            }



        }else{
            header('Location:index.php?action=InicioSesion&error=1');
            exit();
        }
    }

} 