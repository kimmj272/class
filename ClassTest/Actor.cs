using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTest
{
    public class Actor
    {
        // 멤버 변수
        public int m_HP = 0;        // 체력
        public int m_Attack = 0;    //공격력

        // 기본 생성자
        public Actor()
        {
            m_HP = 5000;
            m_Attack = 100;
        }

        // 멤버 함수
        public void SetDamage(int nDamage)
        {
            m_HP -= nDamage;
        }

        public void AddHP(int nValue)
        {
            m_HP += nValue;
        }
    }
}
