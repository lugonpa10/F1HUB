<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Muro - F1 HUB</title>
    <link href="public/css/Muro.css" rel="stylesheet">
</head>
<body>

<?php
// Protección: si no hay sesión activa, redirigir al login
if (!isset($_SESSION['usuario'])) {
    header('Location: index.php?action=inicioSesion');
    exit();
}
$usuario = $_SESSION['usuario'];
$inicial = strtoupper(substr($usuario->nombreUsuario, 0, 1));
?>

<div class="speed-line"></div>

<!-- NAVBAR -->
<nav>
    <a href="index.php?action=Muro" class="nav-logo">F1<span>HUB</span></a>
   
    <div class="nav-user">
        <div class="nav-avatar"><?= $inicial ?></div>
        <span class="nav-username">@<?= htmlspecialchars($usuario->nombreUsuario) ?></span>
    </div>
</nav>

<!-- LAYOUT -->
<div class="layout">

    <!-- LEFT SIDEBAR -->
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
                <li><a href="#"><span class="icon"></span> <span>Perfil</span></a></li>
              
                <li><a href="#"><span class="icon"></span> <span>Notificaciones</span></a></li>
                <li><a href="index.php?action=inicioSesion"><span class="icon"></span> <span>Cerrar sesión</span></a></li>
            </ul>
        </div>
    </aside>

    <!-- MAIN FEED -->
    <main class="feed">
        <div class="feed-header">
            <h2>Muro</h2>
        </div>

        <!-- COMPOSE -->
        <div class="compose-box">
            <div class="compose-avatar"><?= $inicial ?></div>
            <div class="compose-right">
                <textarea 
                    class="compose-textarea" 
                    id="composeText"
                    placeholder="¿Qué está pasando en el paddock?"
                    maxlength="280"
                    oninput="updateChar()"
                ></textarea>
                <div class="compose-divider"></div>
                <div class="compose-footer">
                    <div class="compose-tools">
                    
                    
                       
                    </div>
                    <div style="display:flex; align-items:center; gap: 1rem;">
                        <span class="compose-char" id="charCount">280</span>
                        <button class="btn-post" onclick="publicar()">Publicar</button>
                    </div>
                </div>
            </div>
        </div>

        <!-- POSTS -->
        <div id="feed"></div>
    </main>

   

        <div class="widget">
            <div class="widget-title">Próximas Carreras</div>
            <div class="race-item">
                <span class="race-flag">🇦🇺</span>
                <div>
                    <div class="race-name">Gran Premio de Australia</div>
                    <div class="race-date">16 Mar 2026</div>
                </div>
            </div>
            <div class="race-item">
                <span class="race-flag">🇨🇳</span>
                <div>
                    <div class="race-name">Gran Premio de China</div>
                    <div class="race-date">23 Mar 2026</div>
                </div>
            </div>
            <div class="race-item">
                <span class="race-flag">🇯🇵</span>
                <div>
                    <div class="race-name">Gran Premio de Japón</div>
                    <div class="race-date">6 Abr 2026</div>
                </div>
            </div>
        </div>
    </aside>

</div>

<script>
const usuarioActual = {
    nombre: "<?= htmlspecialchars($usuario->nombre) ?>",
    nombreUsuario: "<?= htmlspecialchars($usuario->nombreUsuario) ?>",
    inicial: "<?= $inicial ?>"
};

let posts = [];



function renderPosts() {
   document.getElementById('feed').innerHTML = posts.map(p => `
        <div class="post">
            <div class="post-info">
                <div class="post-user">@${usuarioActual.nombreUsuario}</div>
                <div class="post-text">${p.texto}</div>
                <div class="post-date">${p.fecha}</div>
            </div>
           <button class="btn-delete" onclick="eliminar(${p.id})" title="Eliminar">✕</button>
        </div>
    `).join('');
}

function eliminar(id) {
    posts = posts.filter(p => p.id !== id);
    renderPosts();
}



function publicar() {
    const txt = document.getElementById('composeText').value.trim();
    if (!txt) return;

    const nuevo = {
        id: Date.now(),
        nombre: usuarioActual.nombre,
        nombreUsuario: usuarioActual.nombreUsuario,
        inicial: usuarioActual.inicial,
        color: '#e10600',
        texto: txt,
        fecha: new Date(),
        likes: 0,
        liked: false
    };

    posts.unshift(nuevo);
    document.getElementById('composeText').value = '';
    document.getElementById('charCount').textContent = '280';
    renderPosts();
}

renderPosts();
</script>
</body>
</html>