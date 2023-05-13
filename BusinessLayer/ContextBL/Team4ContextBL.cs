using BusinessLayer.EntitiesBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ContextBL
{
    public class Team4ContextBL
    {
        public Team4ContextBL()
        {
            AddedFoodBL = new AddedFoodBL();
            CategoryBL = new CategoryBL();
            FoodBL = new FoodBL();
            LifeStyleBL = new LifeStyleBL();
            MealBL = new MealBL();
            UnitBL = new UnitBL();
            UserBL = new UserBL();
            GoalBL = new GoalBL();
            AdminBL = new AdminBL();
        }

        public AddedFoodBL AddedFoodBL { get; set; }
        public CategoryBL CategoryBL { get; set; }
        public FoodBL FoodBL { get; set; }
        public LifeStyleBL LifeStyleBL { get; set; }
        public MealBL MealBL { get; set; }
        public UnitBL UnitBL { get; set; }
        public UserBL UserBL { get; set; }
        public GoalBL GoalBL { get; set; }
        public AdminBL AdminBL { get; set; }
    }
}
