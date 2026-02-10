<?php

session_start();

require_once '/../controladores/ControladorInicioSesion.php';
require_once  '/../controladores/ControladorRegistro.php';

$action = isset($_GET['action']) ? $_GET['action'] : 'registro1';

$ControladorRegistro = new ControladorRegistro();
switch ($action) {
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
    case 'inicioSesion':
        require_once 'vistas/Iniciosesion.php';
        break;
    default:
        require_once 'vistas/Registro.php';
        break;
}
