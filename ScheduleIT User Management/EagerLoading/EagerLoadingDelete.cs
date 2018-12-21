		//Changeset #463: Update the timeoffevent/delete action so that it delets all related entities
		
		//Added Include() method to change from the lazy loading
		//to the eager loading so that it deletes all related entities
		
		// GET: TimeOffEvent/Delete/5
        [Authorize(Roles = "Admin,User")]
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            
            TimeOffEvent timeOffEvent = db.TimeOffEvents.Find(id);
            if (timeOffEvent == null)
            {
                return HttpNotFound();
            }
            return View(timeOffEvent);
        }

        // POST: TimeOffEvent/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin,User")]
        public ActionResult DeleteConfirmed(Guid id)
        {
            // using Include to force eager loading so the messages are deleted without errors
            List<TimeOffEvent> timeOffEvents = db.TimeOffEvents.Include(t => t.Messages).ToList();
            TimeOffEvent timeOffEvent = db.TimeOffEvents.Find(id);
            db.TimeOffEvents.Remove(timeOffEvent);
            db.SaveChanges();
            return RedirectToAction("Index");
        }