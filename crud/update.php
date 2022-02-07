<?php
include 'connect.php';
$id=$_GET['updateid'];
$sql="select * from `crud` where id=$id";
$result=mysqli_query($con,$sql);
$row=mysqli_fetch_assoc($result);
$name=$row['fname'];
$email=$row['email'];
$mobile=$row['mobile'];
$pass=$row['pass'];
if (isset($_POST['submit']))
{
  $name=$_POST['name'];
  $email=$_POST['email'];
  $mobile=$_POST['mobile'];
  $pass=$_POST['password'];

  $sql="update `crud` set id=$id, fname='$name', email='$email', mobile='$mobile', pass='$pass' where id=$id";
  $result=mysqli_query($con,$sql);
  if($result)
  {
    header('location:display.php');
  }
  else
  {
    die(mysqli_error($con)); 
  }
}
?>

<!doctype html>
<html lang="en">
  <head>
    <!-- Required meta tags -->
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">

    <!-- Bootstrap CSS -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet">

    <title>CRUD Operation</title>
    <style>
    input::-webkit-outer-spin-button,
    input::-webkit-inner-spin-button 
    {
      -webkit-appearance: none;
      margin: 0;
    }
    </style>
  </head>
  <body>
    <div class="container my-5">
        <form method="POST"> 
            <div class="mb-3">
                <label>Name</label>
                <input type="text" class="form-control" placeholder="Enter your name here" name="name" style="text-transform:capitalize;" autocomplete="off" value=<?php echo $name?>>
            </div>
            <div class="mb-3">
                <label>Email</label>
                <input type="email" class="form-control" placeholder="Enter your email here" name="email" autocomplete="off" value=<?php echo $email?>> 
            </div>
            <div class="mb-3">
                <label>mobile</label>
                <input type="number" class="form-control" placeholder="Enter your mobile number here" name="mobile" autocomplete="off" value=<?php echo $mobile?>> 
            </div>
            <div class="mb-3">
                <label>Password</label>
                <input type="password" class="form-control" placeholder="Enter your password here" name="password" autocomplete="off" value=<?php echo $pass?>> 
            </div>
            
           
            <button type="submit" class="btn btn-primary" name="submit">Update</button>
        </form>
    </div>

    
  </body>
</html>