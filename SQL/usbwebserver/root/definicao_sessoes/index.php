<?php

// sess�es servem para armazenar informa��es que poder�o ser utilizadas
// em v�rias p�ginas sistema de login, carrinho de compras.

session_start();

$_SESSION['cor'] = "Azul";
$_SESSION['carro'] = "BMW";

echo $_SESSION['cor']."<br>".$_SESSION['carro']."<br>".session_id();

?>