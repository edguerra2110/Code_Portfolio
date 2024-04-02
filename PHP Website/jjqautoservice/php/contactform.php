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

	<h1>Contact Us</h1>
	<div >
		
		<form method="get" action="process.php">
			<!-- Simple text fields -->
			
			
			<label for="first">First Name: </label>
			<input type="text" name="firstName" id="first" placeholder="First Name" size="20" maxlength="30" autofocus required>

	<br>
			
			<label for="last">Last Name: </label>
			<input type="text" name="lastName" id="last" placeholder="Last Name" size="20" maxlength="30" required>
			<br> 
				<label for="pass">Password: </label>
				<input type="password" name="pass" id="pass" placeholder="Password" size="20" maxlength="30" required> <br>
				
				<label for="mail">Email: </label>
				<input type="mail" name="mail" id="mail" placeholder="Email Address" size="20" maxlength="30">
				<br>
				<label for="mail">Phone Number: </label>
				<input type="mail" name="mail" id="mail" placeholder="Phone Number" size="20" maxlength="30">
			
			<br>
			<fieldset>
				<legend>Write your message here:</legend>
				<textarea style=" margin:0 auto;" name="comments" cols="45" maxlength="500" rows="10" placeholder="What would you like to ask us or tell us?"></textarea>
			</fieldset>
			<div style="width:150px; margin:10px auto;">
				<input type="submit" value="Go!">&nbsp;
				<input type="reset" value="Forget it!">
			</div>
		</form>
		
	</div>	
	


