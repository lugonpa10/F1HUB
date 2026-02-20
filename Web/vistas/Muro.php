    <?php
    if (!isset($_SESSION['usuario'])) {
        header('Location: index.php?action=inicioSesion');
        exit();
    }
    require_once 'controladores/ControladorPublicaciones.php';
    $usuario = $_SESSION['usuario'];
    $inicial = strtoupper(substr($usuario->nombreUsuario, 0, 1));
    $ControladorPublicaciones = new ControladorPublicaciones();
    $publicaciones = $ControladorPublicaciones->obtenerTodas();

    ?>
    <!DOCTYPE html>
    <html lang="es">

    <head>
        <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <title>Muro - F1 HUB</title>
        <link href="public/css/Muro.css" rel="stylesheet">
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
                        <li><a href="#" class="active"><span class="icon"></span> <span>Muro</span></a></li>
                        <li><a href="index.php?action=perfil"><span class="icon"></span> <span>Perfil</span></a></li>

                        <li><a href="index.php?action=inicioSesion"><span class="icon"></span> <span>Cerrar sesión</span></a></li>
                    </ul>
                </div>
            </aside>

       
            <main class="feed">
                <div class="feed-header">
                    <h2>Muro</h2>
                </div>

              
                <div class="compose-box">
                    <div class="compose-avatar"><?= $inicial ?></div>
                    <div class="compose-right">
                        <form action="index.php?action=subirPublicacion" method="post">

                            <textarea
                                class="compose-textarea"
                                name="texto"
                                placeholder="¿Qué está pasando en el paddock?"
                                maxlength="280"></textarea>
                            <div class="compose-divider"></div>
                            <div class="compose-footer">
                                <button class="btn-post" type="submit">Publicar</button>
                            </div>
                        </form>
                    </div>
                </div>

                <div id="feed">
                    <?php foreach ($publicaciones as $p): ?>
                        <div class="post">
                            <div class="post-info">
                                <div class="post-user">@<?= htmlspecialchars($p['usuario']['nombreUsuario']) ?></div>
                                <div class="post-text"><?= htmlspecialchars($p['texto']) ?></div>
                                <div class="post-date"><?= date('d/m/Y H:i', $p['fechaPublicacion'] / 1000) ?></div>
                            </div>
                        </div>
                    <?php endforeach; ?>
                </div>
            </main>



            <div class="widget">
                <div class="widget-title">Próximas Carreras</div>
                <div class="race-item">
                    <span class="race-flag">🇦🇺</span>
                    <div>
                        <div class="race-name">Gran Premio de Australia</div>
                        <div class="race-date">8 Mar 2026</div>
                    </div>
                </div>
                <div class="race-item">
                    <span class="race-flag">🇨🇳</span>
                    <div>
                        <div class="race-name">Gran Premio de China</div>
                        <div class="race-date">15 Mar 2026</div>
                    </div>
                </div>
                <div class="race-item">
                    <span class="race-flag">🇯🇵</span>
                    <div>
                        <div class="race-name">Gran Premio de Japón</div>
                        <div class="race-date">29 Mar 2026</div>
                    </div>

                </div>
                </aside>

            </div>


    </body>

    </html>