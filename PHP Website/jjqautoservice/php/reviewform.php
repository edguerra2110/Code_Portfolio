<style>
	
	form {
		border: 1px solid #00A;
		padding: 10px;
		margin-top: 50px;
	}
	input {
		padding: 5px;
		margin: 5px;
	}
	
	
</style>
<h1>Leave a Review</h1>
<div >
	
	<form method="get" action="process.php">
		<!-- Simple text fields -->
		
		
		<label for="first">First Name: </label>
		<input type="text" name="firstName" id="first" placeholder="First Name" size="20" maxlength="30" autofocus required>
<br>
		<label for="last">Last Name: </label>
		<input type="text" name="lastName" id="last" placeholder="Last Name" size="20" maxlength="30" required>
		<div style="width:325px; margin:0 auto;">
			<label for="pass">Password: </label>
			<input type="password" name="pass" id="pass" placeholder="Password" size="20" maxlength="30" required> <br>
			<label for="mail">Email: </label>
			<input type="mail" name="mail" id="mail" placeholder="Email Address" size="20" maxlength="30">
		</div>
		<br>
		<fieldset>
			<legend>Write your review here:</legend>
			<textarea name="comments" cols="45" maxlength="500" rows="10" placeholder="How was your experience? How was the service?"></textarea>
		</fieldset>
		<div style="width:150px; margin:10px auto;">
			<input type="submit" value="Submit">&nbsp;
			<input type="reset" value="Cancel">
		</div>
	</form>
</div>			