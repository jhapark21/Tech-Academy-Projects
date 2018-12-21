		//Changeset #469: When editing a user on the user index, editing the End Date 
		//should update the database just like the Start Date
		
		// POST: /Employer/User/Register
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Register(RegisterViewModel model, string submit)
        {
            ViewBag.Name = new SelectList(db.Roles.ToList(), "", "Name");
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser
                {
                    UserName = model.UserName,
                    Email = model.Email,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    PhoneNumber = model.PhoneNumber,
                    Department = model.Department,
                    Position = model.Position,
                    Address = model.Address,
                    HireDate = model.HireDate,
					//Added EndDate property for Register
                    EndDate = model.EndDate,
                    HourlyPayRate = model.HourlyPayRate,
                    Fulltime = model.Fulltime,
                    BirthDate = model.BirthDate
                };
                var result = await UserManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    var addRole = UserManager.AddToRole(user.Id, model.UserRoles);
                    switch (submit)
                    {
                        //if 'Register' button is clicked
                        //load index of users after user is registered.
                        case "Register":
                            return RedirectToAction("Index");
                        // if 'Add User and Create Schedule' is clicked
                        //load schedule create view
                        case "Save User and Add Schedule":
                            return RedirectToAction("Create", "Schedule", new { id = user.Id });
                    }
                }
                AddErrors(result);
            }
            // If we got this far, something failed, redisplay form
            return View();
        }

        [HttpGet]
        public ActionResult Edit(string Id)
        {

            ApplicationUser dataUser = db.Users.Where(x => x.Id == Id).First();

            RegisterViewModel rv = new RegisterViewModel();
            rv.PhoneNumber = dataUser.PhoneNumber;
            rv.FirstName = dataUser.FirstName;
            rv.LastName = dataUser.LastName;
            rv.UserName = dataUser.UserName;
            rv.Department = dataUser.Department;
            rv.Position = dataUser.Position;
            rv.Address = dataUser.Address;
            rv.HourlyPayRate = dataUser.HourlyPayRate;
            rv.HireDate = dataUser.HireDate.Value;
			//Added EndDate property for Edit
            rv.EndDate = dataUser.EndDate.Value;
            rv.Email = dataUser.Email;
            rv.Fulltime = dataUser.Fulltime;
            rv.CurrentRole = dataUser.Roles.First().RoleId;

            ViewBag.Roles = new SelectList(db.Roles.ToList(), "Id", "Name");


            if (dataUser == null)
            {
                return HttpNotFound();
            }

            return View("Edit", rv);

        }