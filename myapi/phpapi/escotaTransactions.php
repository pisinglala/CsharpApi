<?php
header("Content-Type: application/json");

$host = 'localhost';
$db = 'escota';
$user = 'root';
$pass = '';
$charset = 'utf8mb4';

$dsn = "mysql:host=$host;dbname=$db;charset=$charset";
$options = [
    PDO::ATTR_ERRMODE => PDO::ERRMODE_EXCEPTION,
    PDO::ATTR_DEFAULT_FETCH_MODE => PDO::FETCH_ASSOC,
    PDO::ATTR_EMULATE_PREPARES => false,
];

$pdo = new PDO($dsn, $user, $pass, $options);

if ($_SERVER['REQUEST_METHOD'] === 'GET') {
    $stmt = $pdo->query("SELECT transaction_id, concert_name, concert_date, ticket_price, purchase_date FROM transactions");
    $transactions = $stmt->fetchAll();
    echo json_encode($transactions);
} elseif ($_SERVER['REQUEST_METHOD'] === 'POST') {
    $input = json_decode(file_get_contents('php://input'), true);
    $sql = "INSERT INTO transactions (concert_name, concert_date, ticket_price, purchase_date) VALUES (?,?,?, NOW())";
    $stmt = $pdo->prepare($sql);
    $stmt->execute([$input['concert_name'], $input['concert_date'], $input['ticket_price']]);
    echo json_encode(['message' => 'Transaction added successfully']);
}
?>


