<?php
require_once 'modelos/Usuario.php';

class ControladorRegistro
{
    public function registroPaso1()
    {
        if ($_SERVER['REQUEST_METHOD'] == 'POST') {
            if (session_status() === PHP_SESSION_NONE) {
                session_start();
            }
           
            $_SESSION['datos_registro'] = $_POST;

            header('Location: index.php?action=registro2');
            exit();
        }
    }

    public function registroPaso2()
    {
        if (session_status() === PHP_SESSION_NONE) {
            session_start();
        }

        if ($_SERVER['REQUEST_METHOD'] == 'POST') {
            $password = $_POST['password'];
            $confirm_password = $_POST['confirm_password'];

        
            if ($password != $confirm_password) {
                header('Location: index.php?action=registro2&error=password');
                exit();
            }

           
            $datosRegistro1 = $_SESSION['datos_registro'] ?? null;

            if (!$datosRegistro1) {
                header('Location: index.php?action=registro1');
                exit();
            }

            try {
                $usuario = new Usuario();
                
                
                $resultado = $usuario->registro(
                    $datosRegistro1['nombre'],
                    $datosRegistro1['apellidos'],
                    $datosRegistro1['email'],
                    $datosRegistro1['fechaNacimiento'],
                    $datosRegistro1['nombreUsuario'],
                    $datosRegistro1['genero'],
                    $password 
                );

                if ($resultado && ($resultado === 201 || isset($resultado->nombreUsuario)))  {
                   
                    unset($_SESSION['datos_registro']);
                    header('Location: index.php?action=inicioSesion&success=1');
                    exit();
                } else {
                    throw new Exception("Error en la inserción");
                }

            } catch (Exception $e) {
   
                header('Location: index.php?action=registro1&error=api');
                exit();
            }
        }
    }
}