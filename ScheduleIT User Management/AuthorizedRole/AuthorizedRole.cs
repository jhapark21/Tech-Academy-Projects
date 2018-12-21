		//Changeset #471: When worktimeevent edit is submitted to the controller, it should checked
		//the user's role and only allow edits to start and end if the user has an Admin Role
		
		//When edit is submitted in the work time event, it checks for the user's role and allows
		//admin to edit all of Start time, End time, and Note but only allows user to edit Note. 
			
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin,User")]
        [ActionName("Edit")]
        public ActionResult EditTime(Guid? Id) //gets the worktimeEvent ID
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var EventToUpdate = db.WorkTimeEvents.Find(Id); //searches for WorktimeEvent with given Id in the DB
            if (User.IsInRole("Admin")) //edit for admin role
            {
                TryUpdateModel(EventToUpdate, "",
         new string[] { "Start", "End", "Note" });
                try
                {
                    db.SaveChanges();

                    return RedirectToAction("Index");
                }
                catch (DataException /* dex */)
                {
                    //Log the error (uncomment dex variable name and add a line here to write a log.

                }
            }
            else User.IsInRole("User"); //edit for user role
            {
                TryUpdateModel(EventToUpdate, "",
         new string[] { "Note" });
                try
                {
                    db.SaveChanges();

                    return RedirectToAction("Index");
                }
                catch (DataException /* dex */)
                {
                    //Log the error (uncomment dex variable name and add a line here to write a log.

                }
            }
                ViewBag.Id = new SelectList(db.Users, "Id", "FirstName");
            return View(Id);
        }