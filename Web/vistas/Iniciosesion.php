<!DOCTYPE html>
<html lang="es">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Login - F1 Social</title>
    <link rel="stylesheet" href="public/css/inicioSesion.css">
</head>

<body>

    <nav class="top-menu">
        <div class="logo">F1 HUB</div>
        <ul>
            <li><a href="#">Pilotos</a></li>
            <li><a href="#">Coches</a></li>
            <li><a href="#">Ajustes</a></li>
        </ul>
    </nav>

    <div class="main-container">

        <div class="side-panel left-panel" id="slider-left">
        </div>

        <div class="login-container">
            <div class="login-box">
                <h2>Iniciar Sesión</h2>
                <p>Bienvenido al Paddock</p>
                
                <?php if (isset($_GET['success']) && $_GET['success'] == 1): ?>
                    <div>
                        <strong>¡Registro exitoso!</strong> 
                    </div>
                <?php endif; ?>

                <form action="index.php?action=validarInicioSesion" method="POST">
                    <div class="input-group">
                        <label for="username">Nombre de Usuario</label>
                        <input type="text" id="username" name="nombreUsuario" required>
                    </div>

                    <div class="input-group">
                        <label for="password">Contraseña</label>
                        <input type="password" id="password" name="password" required>
                    </div>

                    <button type="submit" class="btn-confirm">Confirmar</button>
                </form>

                <div class="register-link">
                    ¿No tienes cuenta? <a href="index.php?action=registro1">Crear una cuenta</a>
                </div>
            </div>
        </div>

        <div class="side-panel right-panel" id="slider-right">
        </div>

    </div>

    <script src="public/js/slider.js"></script>
</body>

</html>