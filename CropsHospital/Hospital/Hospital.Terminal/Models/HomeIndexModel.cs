﻿using System.Collections.Generic;
using Hospital.ViewModel;

namespace Hospital.Terminal.Models
{
    /// <summary>
    /// 首页
    /// </summary>
    public class HomeIndexModel
    {
        /// <summary>
        /// 问题列表
        /// </summary>
        public List<QuestionInfo> QuestionList { get; set; }

        /// <summary>
        /// 医院列表
        /// </summary>
        public List<HospitalInfo> HospitalList { get; set; }
    }
}