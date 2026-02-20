<?php
if (!isset($_SESSION['usuario'])) {
    header('Location: index.php?action=inicioSesion');
    exit();
}
require_once 'controladores/ControladorPublicaciones.php';
$usuario = $_SESSION['usuario'];
$inicial = strtoupper(substr($usuario->nombreUsuario, 0, 1));
$ControladorPublicaciones = new ControladorPublicaciones();
$publicaciones = $ControladorPublicaciones->obtener($usuario->idUsuario);

?>

<!DOCTYPE html>
<html lang="es">

<head>
    <meta charset="UTF-8">
    <title>Perfil - F1 HUB</title>
    <link href="public/css/Perfil.css" rel="stylesheet">
</head>

<body>

    <div class="speed-line"></div>

    <nav>
        <a href="index.php?action=Muro" class="nav-logo">F1<span>HUB</span></a>
        <div class="nav-user">
            <div class="nav-avatar"><?= $inicial ?></div>
            <span class="nav-username">@<?= htmlspecialchars($usuario->nombreUsuario) ?></span>
        </div>
    </nav>

    <div class="layout">

        <aside class="sidebar">
            <div class="profile-card">
                <div class="profile-card-avatar"><?= $inicial ?></div>
                <div class="profile-card-name"><?= htmlspecialchars($usuario->nombre) ?></div>
                <div class="profile-card-user">@<?= htmlspecialchars($usuario->nombreUsuario) ?></div>
            </div>
            <div class="sidebar-section">
                <div class="sidebar-title">Navegación</div>
                <ul class="sidebar-nav">
                    <li><a href="index.php?action=Muro"><span class="icon"></span> <span>Muro</span></a></li>
                    <li><a href="index.php?action=perfil" class="active"><span class="icon"></span> <span>Perfil</span></a></li>
                    <li><a href="index.php?action=logout"><span class="icon"></span> <span>Cerrar sesión</span></a></li>
                </ul>
            </div>
        </aside>

        <main class="feed">
            <div class="feed-header">
                <h2> Mi Perfil</h2>
            </div>

            <?php if (isset($_GET['success'])): ?>
                <div class="alert-success"> Perfil actualizado correctamente.</div>
            <?php endif; ?>

            <?php if (isset($_GET['error'])): ?>
                <div class="alert-error"> Error al actualizar el perfil.</div>
            <?php endif; ?>

            <div class="compose-box-perfil">

                <div class="perfil-header-user">
                    <div class="compose-avatar"><?= $inicial ?></div>
                    <div>
                        <div class="perfil-nombre"><?= htmlspecialchars($usuario->nombre) ?> <?= htmlspecialchars($usuario->apellidos) ?></div>
                        <div class="perfil-username">@<?= htmlspecialchars($usuario->nombreUsuario) ?></div>
                    </div>
                </div>

                <div class="compose-divider"></div>

                <form action="index.php?action=editarUsuario" method="POST" class="perfil-form">

                    <div class="perfil-grid-2">
                        <div class="perfil-field">
                            <label>Nombre</label>
                            <input type="text" name="nombre" value="<?= htmlspecialchars($usuario->nombre) ?>" required>
                        </div>
                        <div class="perfil-field">
                            <label>Apellidos</label>
                            <input type="text" name="apellidos" value="<?= htmlspecialchars($usuario->apellidos) ?>" required>
                        </div>
                    </div>

                    <div class="perfil-field">
                        <label>Email</label>
                        <input type="email" name="email" value="<?= htmlspecialchars($usuario->email) ?>" required>
                    </div>

                    <div class="perfil-grid-2">
                        <div class="perfil-field">
                            <label>Fecha de Nacimiento</label>
                            <input type="date" name="fechaNacimiento" value="<?= htmlspecialchars($usuario->fechaNacimiento) ?>" required>
                        </div>
                        <div class="perfil-field">
                            <label>Género</label>
                            <select name="genero">
                                <option value="Hombre" <?= $usuario->genero == 'Hombre' ? 'selected' : '' ?>>Hombre</option>
                                <option value="Mujer" <?= $usuario->genero == 'Mujer' ? 'selected' : '' ?>>Mujer</option>
                                <option value="Otro" <?= $usuario->genero == 'Otro' ? 'selected' : '' ?>>Otro</option>
                                <option value="No especificado" <?= $usuario->genero == 'No especificado' ? 'selected' : '' ?>>Prefiero no decirlo</option>
                            </select>
                        </div>
                    </div>

                    <div class="compose-divider"></div>

                    <div class="perfil-submit">
                        <button type="submit" class="btn-post">Guardar cambios</button>
                    </div>

                </form>

                <div id="feed-perfil">
                    <?php 
                   
                    foreach ($publicaciones as $p): 
                    ?>
                        <div class="post">
                            <div class="post-info">
                                <div class="post-text"><?= htmlspecialchars($p['texto']) ?></div>
                                <div class="post-date"><?= date('d/m/Y H:i', $p['fechaPublicacion'] / 1000) ?></div>
                            </div>
                            <form method="POST" action="index.php?action=eliminarPublicacion">
                                <input type="hidden" name="id" value="<?= $p['idPubli'] ?>">
                                <button type="submit" class="btn-delete">✕</button>
                            </form>
                        </div>
                    <?php endforeach; ?>
                </div>
            </div>
        </main>

    </div>

</body>

</html>