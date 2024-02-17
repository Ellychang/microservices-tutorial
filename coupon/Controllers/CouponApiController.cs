using AutoMapper;
using coupon.Data;
using coupon.Models;
using coupon.Models.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace coupon.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CouponApiController : ControllerBase
    {
        private readonly AppDbContext  _db;
        private readonly ResponseDto _responseDto;
        private IMapper _mapper;

        public CouponApiController(AppDbContext db, IMapper mapper)
        {
            _db = db;
            _responseDto = new ResponseDto();
            _mapper = mapper;
        }

        [HttpGet]
        public ResponseDto Get()
        {
            try
            {
                _responseDto.IsSuccess = true;
                IEnumerable<Coupon> objList= _db.Coupons.ToList();
                _responseDto.Results = _mapper.Map<IEnumerable<Coupon>>(objList);
            }
            catch (Exception ex)
            {
                _responseDto.IsSuccess = false;
                _responseDto.Message = ex.Message;
            }
            return _responseDto;
        }

        [HttpGet]
        [Route("{id:int}")]
        public ResponseDto Get(int id)
        {
            try
            {
               Coupon obj= _db.Coupons.First(x=>x.CoupionId == id);
                _responseDto.Results = _mapper.Map<CouponDto>(obj); // map coupon to couponDto
            }
            catch (Exception ex)
            {

               _responseDto
                    .IsSuccess = false;
                _responseDto.Message = ex.Message;
            }

            return _responseDto;
        }

        [HttpGet]
        [Route("GetByCode/{code}")]
        public ResponseDto GetByCode(string code)
        {
            try
            {
                Coupon obj = _db.Coupons.First(x => x.CouponCode == code);
                _responseDto.Results = _mapper.Map<CouponDto>(obj); // map coupon to couponDto
            }
            catch (Exception ex)
            {

                _responseDto
                     .IsSuccess = false;
                _responseDto.Message = ex.Message;
            }

            return _responseDto;
        }

        [HttpPost]
        public ResponseDto Post([FromBody] CouponDto couponDto)
        {
            try
            {
                Coupon obj = _mapper.Map<Coupon>(couponDto);
                _db.Coupons.Add(obj);
                _db.SaveChanges(); // go to database and create that record

                _responseDto.Results = _mapper.Map<CouponDto>(obj); // map coupon to couponDto
            }
            catch (Exception ex)
            {

                _responseDto
                     .IsSuccess = false;
                _responseDto.Message = ex.Message;
            }

            return _responseDto;
        }

        [HttpPut]
        public ResponseDto Put([FromBody] CouponDto couponDto)
        {
            try
            {
                Coupon obj = _mapper.Map<Coupon>(couponDto);
                _db.Coupons.Update(obj);
                _db.SaveChanges(); // go to database and update that record

                _responseDto.Results = _mapper.Map<CouponDto>(obj); // map coupon to couponDto
            }
            catch (Exception ex)
            {

                _responseDto
                     .IsSuccess = false;
                _responseDto.Message = ex.Message;
            }

            return _responseDto;
        }

        [HttpDelete]
        public ResponseDto delete(int id)
        {
            try
            {
                Coupon obj = _db.Coupons.First(x => x.CoupionId == id);
                _db.Coupons.Remove(obj);
                _db.SaveChanges(); // go to database and delete that record
            }
            catch (Exception ex)
            {

                _responseDto
                     .IsSuccess = false;
                _responseDto.Message = ex.Message;
            }

            return _responseDto;
        }
    }
}
