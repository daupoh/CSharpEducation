using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEducation
{
    class CDinnerParty
    {
        public const decimal 
            COST_OF_FOOD_PER_PERSON = 25,
            HEALTHY_DISCOUNT=0.05M,
            ALCOHOL_PRICE=20,
            HEALTHY_PRICE=5, 
            SPECIAL_DECOR=15,
            REGULAR_DECOR=7.5M,
            SPECIAL_CONTRIBUTION=50,
            REGULAR_CONTRIBYTION=30;
        decimal m_iNumberOfPeople =1,
            m_dcCostOfBevearegesPerPerson = ALCOHOL_PRICE,
            m_dcCostOfDecorations= REGULAR_DECOR,
            m_dcDecorContribution= REGULAR_CONTRIBYTION, 
            m_dcDiscount=0;   

        public void setHealthyOption(bool isHealthy)
        {           
            if (isHealthy)
            {
                m_dcDiscount = HEALTHY_DISCOUNT;
                m_dcCostOfBevearegesPerPerson = HEALTHY_PRICE;
            }
            else
            {
                m_dcDiscount = 0;
                m_dcCostOfBevearegesPerPerson = ALCOHOL_PRICE;
            }
        }
        public void calculateCostOfDecorations(bool isSpecial)
        {
            if (isSpecial)
            {
                m_dcDecorContribution = SPECIAL_CONTRIBUTION;
                m_dcCostOfDecorations = SPECIAL_DECOR;
            }
            else
            {
                m_dcDecorContribution = REGULAR_CONTRIBYTION;
                m_dcCostOfDecorations = REGULAR_DECOR;
            }
        }
        public decimal CalculateCost(decimal nPersons)
        {
            decimal costResult = 0;
            if (nPersons <= 0)
                costResult = 0;
            else
            {
                m_iNumberOfPeople = nPersons;
                decimal sumOfDrinksAndFood = nPersons * COST_OF_FOOD_PER_PERSON + nPersons * m_dcCostOfBevearegesPerPerson,
                    sumOfDecoration = nPersons * m_dcCostOfDecorations + m_dcDecorContribution,
                    sumWithOutDiscount = sumOfDecoration + sumOfDrinksAndFood,
                    discount = sumWithOutDiscount * m_dcDiscount;

                costResult = sumWithOutDiscount - discount;
            }
            return costResult;
        }
        
    }
}
