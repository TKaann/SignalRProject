﻿using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.ProductDto;
using SignalR.DtoLayer.TestimonialDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly ITestimonialService _testimonialService;
        private readonly IMapper _mapper;

        public TestimonialController(ITestimonialService testimonialService, IMapper mapper)
        {
            _testimonialService = testimonialService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult TestimonialList()
        {
            var value = _mapper.Map<List<ResultTestimonialDto>>(_testimonialService.TGetListAll());
            return Ok(value);
        }
        [HttpPost]
        public IActionResult CreateTestimonial(CreateTestimonialDto createtestimonialDto)
        {
            _testimonialService.TAdd(new Testimonial()
            {
                Comment = createtestimonialDto.Comment,
                ImageUrl = createtestimonialDto.ImageUrl,
                Name = createtestimonialDto.Name,
                Status = createtestimonialDto.Status,
                Title = createtestimonialDto.Title
            });
            return Ok("Musteri Yorum Bilgisi Eklendi");

        }
        [HttpDelete("{id}")]
        public IActionResult DeleteTestimonial(int id)
        {
            var value = _testimonialService.TGetByID(id);
            _testimonialService.TDelete(value);
            return Ok("Musteri Yorum Bilgisi Silindi");
        }
        [HttpGet("{id}")]
        public IActionResult GetTestimonial(int id)
        {
            var value = _testimonialService.TGetByID(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateTestimonial(UpdateTestimonialDto updateTestimonialDto)
        {
            _testimonialService.TUpdate(new Testimonial()
            {
                Title = updateTestimonialDto.Title,
                Status = updateTestimonialDto.Status,
                Comment = updateTestimonialDto.Comment,
                Name = updateTestimonialDto.Name,
                ImageUrl= updateTestimonialDto.ImageUrl,
                TestimonialID = updateTestimonialDto.TestimonialID
            });
            return Ok("Musteri Yorum Bilgisi Guncellendi");
        }
    }
}
