<!-- Come utilizzare una form e lasciare i campi precompilati
si può usare anche get anf $_GET per passare i dati usando l'url -->
<!DOCTYPE html>
<html>
<head><title>PHP Form Handling</title></head>
<body>
<form action = "" method = "post">
Enter Name <BR>
<input type = "text" name = "studentname" value = <?php if (isset($_POST['studentname']))echo $_POST['studentname'];?>>
<BR><BR>
Favorite Subject(s)<BR>
<input type = "checkbox" name = "subj[]" value ="EL" 
<?php if (isset($_POST['subj']) && in_array('EL',$_POST['subj']))echo 'checked';?>>English
<input type = "checkbox" name = "subj[]" value ="MA"
<?php if (isset($_POST['subj']) && in_array('MA',$_POST['subj']))echo 'checked';?>>Math
<input type = "checkbox" name = "subj[]" value ="PG"
<?php if (isset($_POST['subj']) && in_array('PG',$_POST['subj']))echo 'checked';?>>Programming
<BR><BR>
Gender <BR>
<input type = "radio" name = "gender" value ="M"
<?php if (isset($_POST['gender']) && $_POST['gender'] == 'M')echo 'checked';?>>Male
<input type = "radio" name = "gender" value ="F"
<?php if (isset($_POST['gender']) && $_POST['gender'] == 'F')echo 'checked';?>>Female
<BR><BR>
<input type = "submit" name="sm" value = "SubmitForm">
</form>

<?php


if (isset($_POST['sm']))
print_r($_POST);


?>

</body>
</html>