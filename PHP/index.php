<!DOCTYPE html>
<html>
    <head>
        <meta charset="UTF-8">
        <title>PHP</title>
        <link rel="stylesheet" type="text/css" href="style.css"/>
    </head>
    <body bgcolor="#06283D">
        <header height="20%">
            <div id="logo">
                <h1>My PHP page</h1>
            </div>
        </header>
        <main height="70%">
            <div class="form">
                <?php
                    $account = ["blackcoffee" => "123456789","irisk1009" => "987654321"];
                    $message = "";
                    $validation_error = "your password is incorrect!";
                    if($_SERVER["REQUEST_METHOD"] == "POST"){
                        $username= $_POST["username"];
                        $password = $_POST["password"];
                        if(isset($account[$username]) && $password === $account[$username]){
                            header("Location: APIWeb/Movie.html");
                            exit;
                        } elseif(isset($account[$username]) && $password != $account[$username]){
                            $message = $username." ".$validation_error;
                        } else{
                            header("Location: Signin.php");
                            exit;                        }
                    }
                ?>
                <h1>LOG IN</h1>
                <span><?=$message?></span>
                <table>
                <form method="post">
                    <tr>
                        <td><h2>Username:</h2></td>
                        <td><input type="text" name="username"></td>
                    <tr> 
                    <tr>
                        <td><h2>Password:</h2></td>
                        <td><input type="password" name="password"></td>
                    </tr>
                    <tr>
                        <td cols="2">
                            <center><input type="submit" value="Logins"></center>
                        </td>
                    </tr>
                </form>
                </table>
                <a href="index.php">Reset</a>
            </div>        
        </main>
        <footer height="10%"></footer>
    </body>
</html>