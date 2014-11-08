/**
 * 
 */
package me.sample.alohachina.platform.controller;

import me.sample.alohachina.business.service.VehicleService;
import me.sample.alohachina.model.Vehicle;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.data.domain.Page;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;

/**
 * @author jianwang
 *
 */
@RestController
public class VehicleController {

	@Autowired
	private VehicleService vehicleService;

	@RequestMapping(method = RequestMethod.GET, value = "/vehicles")
	public Page<Vehicle> getAllVehicles(
			@RequestParam(value = "pageIndex", required = false) Integer pageIndex,
			@RequestParam(value = "pageSize", required = false) Integer pageSize) {

		if(pageIndex == null || pageIndex < 1)
		{
			pageIndex = 1;
		}
		if(pageSize == null || pageSize < 1)
		{
			pageSize = 10;
		}
		return vehicleService.getAll(pageIndex, pageSize);
	}
}
