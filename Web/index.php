<?php

session_start();

require_once 'controladores/ControladorInicioSesion.php';
require_once 'controladores/ControladorRegistro.php';
require_once 'controladores/ControladorPerfil.php';
require_once 'controladores/ControladorPublicaciones.php';

$action = isset($_GET['action']) ? $_GET['action'] : 'inicioSesion';

$ControladorRegistro = new ControladorRegistro();
$ControladorInicioSesion = new ControladorInicioSesion();
$ControladorPerfil = new ControladorPerfil();
$ControladorPublicaciones = new ControladorPublicaciones();

switch ($action) {
    case 'inicioSesion':
        require_once 'vistas/InicioSesion.php';
        break;
    case 'validarInicioSesion':
        $ControladorInicioSesion->IniciarSesion();
        break;
    case 'registro1':
        require_once 'vistas/Registro.php';
        break;
    case 'registroPaso1':
        $ControladorRegistro->registroPaso1();
        break;
    case 'registro2':
        require_once 'vistas/Registro2.php';
        break;
    case 'registroPaso2':
        $ControladorRegistro->registroPaso2();
        break;
    case 'Muro':
        require_once 'vistas/Muro.php';
        break;
    case 'perfil':
        require_once 'vistas/Perfil.php';
        break;
    case 'editarUsuario':
        $ControladorPerfil->editar();
        break;
    case 'logout':
        session_destroy();
        header('Location: index.php?action=inicioSesion');
        exit();
        break;
    case 'subirPublicacion':
        $ControladorPublicaciones->subir();
        break;
    case 'eliminarPublicacion':
        $ControladorPublicaciones->eliminar();
        break;
    default:
        require_once 'vistas/InicioSesion.php';
        break;
}
