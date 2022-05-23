<?php

$servidor="localmarket-db.cogascnxjvfa.us-east-1.rds.amazonaws.com";
$usuario="admin";
$clave="patata14";
$db="localmarket_db";

@$mysqli= new mysqli($servidor,$usuario,$clave,$db);
if ($mysqli->connect_errno){
    echo "Fallo al conectar a MySql: ".$mysqli->connect_error." ".$mysqli->connect_errno;
}else{
    echo "SE HA CONECTADO AL SERVIDOR MYSQL";
}
?>