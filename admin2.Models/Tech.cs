using System;
using System.Collections.Generic;
using System.Text;

namespace admin2.Models
{
    //모델 클래스 : Teches 테이블과 일대일로 연결되는 모델 클래스
    public class Tech
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }
}
