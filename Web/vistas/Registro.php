
<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Registro Paso 1 - F1 HUB</title>
    <link rel="stylesheet" href="/public/css/Registro.css">
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

    <main class="auth-wrapper">
        <div class="login-box">
            <h2>Crear Cuenta</h2>
         

            <form>
                <div class="input-group">
                    <label for="nombre">Nombre</label>
                    <input type="text" id="nombre" name="nombre" required>
                </div>
                <div class="input-group">
                    <label for="apellidos">Apellidos</label>
                    <input type="text" id="apellidos" name="apellidos" required>
                </div>
                <div class="input-group">
                    <label for="email">Correo Electrónico</label>
                    <input type="email" id="email" name="email" required>
                </div>
                <div class="input-group">
                    <label for="nombreUsuario">Nombre de Usuario</label>
                    <input type="text" id="nombreUsuario" name="nombreUsuario" required>
                </div>

                <div class="radio_group">
                    <input type="radio" name="value" id="radio1">
                    <label for="radio1" class="radio_label">Hombre</label>
                    
                    <input type="radio" name="value" id="radio2">
                    <label for="radio2" class="radio_label">Mujer</label>

                     <input type="radio" name="value" id="radio3">
                    <label for="radio3" class="radio_label">Otro</label>

                    <input type="radio" name="value" id="radio4">
                    <label for="radio4" class="radio_label">Prefiero no decirlo</label>
                </div>

                <a href="Registro2.php" class="btn-confirm" style="text-decoration: none; display: block; text-align: center; line-height: 45px;">Siguiente</a>
            </form>

            <div class="register-link">
                ¿Ya tienes cuenta? <a href="Iniciosesion.php">Inicia sesión</a>
            </div>
        </div>
    </main>

</body>
</html>