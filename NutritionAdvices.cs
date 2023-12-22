using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitMe
{
    public partial class NutritionAdvices : Form
    {

        private List<NutritionTip> allTips;
        private const int TipsToShow = 10;

        public NutritionAdvices()
        {
            InitializeComponent();
            LoadTips();
        }

        Home home = null;


        private void LoadTips()
        {
            // Initialize the list of tips
            allTips = new List<NutritionTip>
            {
                new NutritionTip("Eat a variety of nutrient-rich foods."),
                new NutritionTip("Include fruits and vegetables in every meal."),
                new NutritionTip("Stay hydrated; drink plenty of water."),
                new NutritionTip("Choose whole grains over refined grains."),
                new NutritionTip("Limit processed and sugary foods."),
                new NutritionTip("Cook at home more often."),
                new NutritionTip("Be mindful of your eating habits."),
                new NutritionTip("Practice moderation, not deprivation."),
                new NutritionTip("Enjoy your meals and savor the flavors."),
                new NutritionTip("Prioritize portion control."),
                new NutritionTip("Include lean proteins in your diet."),
                new NutritionTip("Control your sodium intake."),
                new NutritionTip("Choose healthy fats, such as avocados and nuts."),
                new NutritionTip("Read food labels and be aware of hidden sugars."),
                new NutritionTip("Get your nutrients from whole foods, not supplements."),
                new NutritionTip("Listen to your body's hunger and fullness cues."),
                new NutritionTip("Plan your meals and snacks ahead of time."),
                new NutritionTip("Don't skip breakfast; it jumpstarts your metabolism."),
                new NutritionTip("Monitor your alcohol intake."),
                new NutritionTip("Choose snacks that are high in protein and fiber."),
                new NutritionTip("Be aware of emotional eating triggers."),
                new NutritionTip("Opt for grilled, steamed, or baked foods instead of fried."),
                new NutritionTip("Experiment with herbs and spices to add flavor without extra calories."),
                new NutritionTip("Focus on mindful eating; savor each bite."),
                new NutritionTip("Pay attention to portion sizes."),
                new NutritionTip("Include a variety of colors on your plate for a range of nutrients."),
                new NutritionTip("Choose whole fruits over fruit juices."),
                new NutritionTip("Be cautious with 'low-fat' or 'fat-free' labels; they may contain added sugars."),
                new NutritionTip("Be cautious with 'low-fat' or 'fat-free' labels; they may contain added sugars."),
                new NutritionTip("Limit your intake of sugary beverages."),
                new NutritionTip("Pack healthy snacks when you're on the go."),
                new NutritionTip("Limit your intake of processed and red meats."),
                new NutritionTip("Opt for water instead of sugary drinks."),
                new NutritionTip("Don't shop for groceries when you're hungry."),
                new NutritionTip("Choose whole, unprocessed foods whenever possible."),
                new NutritionTip("Include sources of omega-3 fatty acids in your diet."),
                new NutritionTip("Be cautious with condiments, as they can add hidden calories."),
                new NutritionTip("Try plant-based protein sources, such as beans and lentils."),
                new NutritionTip("Experiment with different cooking methods to keep meals interesting."),
                new NutritionTip("Be aware of added sugars in seemingly healthy foods."),
                new NutritionTip("Choose whole-grain options for added fiber."),
                new NutritionTip("Practice mindful snacking; avoid eating in front of the TV or computer."),
                new NutritionTip("Get creative with salads; add a variety of veggies and proteins."),
                new NutritionTip("Choose unsweetened dairy alternatives."),
                new NutritionTip("Be cautious with salad dressings; they can be high in calories."),
                new NutritionTip("Opt for whole, fresh fruit instead of fruit-flavored snacks."),
                new NutritionTip("Include a mix of different protein sources in your diet."),
                new NutritionTip("Be cautious with energy bars; they can be high in sugar."),
                new NutritionTip("Be mindful of portion sizes when dining out."),
                new NutritionTip("Try to eat meals at the same time each day for consistency."),
                new NutritionTip("Be cautious with 'all-natural' or 'organic' labels; they don't always mean healthy."),
                new NutritionTip("Practice gratitude; savor the experience of enjoying a good meal."),
                new NutritionTip("Don't fear healthy fats; they're essential for your body."),
                new NutritionTip("Be cautious with 'gluten-free' labels; they don't necessarily mean healthier."),
                new NutritionTip("Choose snacks that combine protein and fiber for lasting energy."),
                new NutritionTip("Limit your intake of high-calorie, low-nutrient foods."),
                new NutritionTip("Choose snacks with a balance of macronutrients."),
                new NutritionTip("Be cautious with 'low-carb' labels; they may be high in other unhealthy ingredients."),
                new NutritionTip("Be aware of added sugars in condiments and sauces."),
                new NutritionTip("Choose nutrient-dense snacks, such as nuts and seeds."),
                new NutritionTip("Be cautious with 'diet' or 'light' products; they may not be as healthy as they seem."),
                new NutritionTip("Prioritize sleep; it's essential for overall health and weight management."),
                new NutritionTip("Experiment with new recipes to keep meals exciting."),
                new NutritionTip("Be cautious with 'low-calorie' labels; they may lack essential nutrients."),
                new NutritionTip("Include fermented foods, such as yogurt and sauerkraut, for gut health."),
                new NutritionTip("Be cautious with fruit juices; they can be high in sugar and lack fiber."),
                new NutritionTip("Limit your intake of high-calorie coffee beverages."),
                new NutritionTip("Choose whole, unprocessed snacks for lasting energy."),
                new NutritionTip("Be mindful of your alcohol intake; it can contribute to empty calories."),
                new NutritionTip("Choose healthy snacks with a balance of carbohydrates, protein, and fats."),
                new NutritionTip("Be cautious with 'sugar-free' products; they may contain artificial sweeteners."),
                new NutritionTip("Prioritize stress management; it can impact your eating habits."),
                new NutritionTip("Choose lean cuts of meat for protein."),
                new NutritionTip("Be cautious with 'organic' labels; they don't guarantee nutritional superiority."),
                new NutritionTip("Include a variety of nuts and seeds in your diet for healthy fats."),
                new NutritionTip("Be cautious with 'low-fat' snacks; they may be high in sugar."),
                new NutritionTip("Be cautious with 'low-calorie' snacks; they may lack nutritional value."),
                new NutritionTip("Choose plain yogurt and add your own flavor with fresh fruit."),
                new NutritionTip("Be cautious with 'protein bars'; they may be high in sugar."),
                new NutritionTip("Include a mix of colorful vegetables in your meals."),
                new NutritionTip("Choose whole fruits over fruit-flavored snacks."),
                new NutritionTip("Be cautious with 'natural' labels; they may not be regulated."),
                new NutritionTip("Choose snacks with a balance of macronutrients for sustained energy."),
                new NutritionTip("Be cautious with 'sugar-free' products; they may contain artificial sweeteners."),
                new NutritionTip("Choose whole, unprocessed snacks for lasting energy."),
                new NutritionTip("Be cautious with 'low-fat' snacks; they may be high in sugar."),
                new NutritionTip("Be cautious with 'low-calorie' snacks; they may lack nutritional value."),
                new NutritionTip("Choose plain yogurt and add your own flavor with fresh fruit."),
                new NutritionTip("Be cautious with 'protein bars'; they may be high in sugar."),
                new NutritionTip("Include a mix of colorful vegetables in your meals.")
            };

            DisplayRandomTips();
        }

        private void DisplayRandomTips()
        {
            // Shuffle the list of tips
            var random = new Random();
            var shuffledTips = allTips.OrderBy(t => random.Next()).ToList();

            // Display the first 10 tips in your labels
            for (int i = 0; i < TipsToShow; i++)
            {
                Control[] controls = Controls.Find($"txtTip{i + 1}", true);
                if (controls.Length > 0 && controls[0] is TextBox txtBox)
                {
                    txtBox.Text = shuffledTips[i].TipText;
                }
            }
        }

        // NutritionTip class to hold information about a nutrition tip
        public class NutritionTip
        {
            public string TipText { get; set; }

            public NutritionTip(string tipText)
            {
                TipText = tipText;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (home == null || home.IsDisposed)
            {
                home = new Home();
            }

            home.Show();
            this.Hide();
        }
    }
}
