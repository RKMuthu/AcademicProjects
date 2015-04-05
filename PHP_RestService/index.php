<?php

require 'Slim/Slim.php';

$app = new Slim();

$app->get('/diseases', 'getDetails');

$app->run();

function getDetails() {

$url="select toxins_category.name as Toxin_Cname,toxins_disease.name as toxins_Dname,toxins_contaminant.name as toxins_Contname,toxins_links.evidence
as evidence,toxins_reference.url as reference from toxins_category inner join toxins_disease_category on toxins_category.ID = toxins_disease_category.cid 
inner join toxins_disease  on toxins_disease_category.did = toxins_disease.ID inner join toxins_links on toxins_disease.ID = toxins_links.disease_id 
inner join toxins_contaminant  on toxins_links.contaminant_id = toxins_contaminant.ID inner join toxins_disease_reference on  
toxins_disease_reference.did = toxins_disease.ID inner join toxins_reference  on toxins_reference.ID = toxins_disease_reference.rid ";

$db = new PDO("mysql:dbname=chealth_xar2;host=localhost", "root", "Rakeshkumar@12");
$rows = $db->query($url);
$users = $rows->fetchAll(PDO::FETCH_OBJ);
echo '{"result":'.json_encode($users).'}';
} 

?>