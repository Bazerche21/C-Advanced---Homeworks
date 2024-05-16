
using TimeTracking.Domain.Database;
using TimeTracking.Domain.DomainInterfaces;
using TimeTracking.Domain.Models;
using TimeTracking.Services.Implementations;
using TimeTracking.Services.Interfaces;

Database<User> _database = new Database<User>(); 
IUser _userRepository = new UserRepository();
IActivity _activityRepository = new AcitivityRepository();
IActivityService<Activity> _activityService = new ActivityService<Activity>();
IAuthenticationService<User> _uthenticationService = new AuthenticationService<User>(_database);
IUserManagmentService<User> _userManagmentService = new UserManagmentService<User>(_database);
MainMenuService mainMenuService = new MainMenuService();
User _currentUser = null;