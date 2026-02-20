<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Registro Paso 2 - F1 HUB</title>
    <link rel="stylesheet" href="public/css/Registro.css">
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
            <h2>Seguridad</h2>
     

            <form action="index.php?action=registroPaso2" method="POST">
                <div class="input-group">
                    <label for="password">Contraseña</label>
                    <input type="password" id="password" name="password" required>
                </div>
                <div class="input-group">
                    <label for="confirm_password">Confirmar Contraseña</label>
                    <input type="password" id="confirm_password" name="confirm_password" required>
                </div>

                <button type="submit" class="btn-confirm">Confirmar Registro</button>
                
                <div style="margin-top: 15px;">
                    <a href="index.php?action=registro1" style="color: #e10600; text-decoration: none; font-size: 0.8rem; font-weight: bold;">« Volver a mis datos</a>
                </div>
            </form>
        </div>
    </main>

</body>
</html>