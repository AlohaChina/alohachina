/**
 * 
 */
package me.sample.alohachina.business.implementation;

import me.sample.alohachina.business.service.VehicleService;
import me.sample.alohachina.model.Vehicle;
import me.sample.alohachina.repository.VehicleRepository;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.data.domain.Page;
import org.springframework.data.domain.PageRequest;
import org.springframework.data.domain.Sort.Direction;
import org.springframework.stereotype.Service;

/**
 * @author jianwang
 *
 */
@Service
public class VehicleServiceImpl implements VehicleService {

	@Autowired
	private VehicleRepository repository;

	@Override
	public Page<Vehicle> getAll(int pageIndex, int pageSize) {
		return repository.findAll(new PageRequest(pageIndex - 1, pageSize, Direction.ASC, "Id"));
	}

	@Override
	public long count() {
		return repository.count();
	}

	@Override
	public Vehicle findByKey(Vehicle item) {
		return repository.findOne(item.getId());
	}

	@Override
	public Vehicle addItem(Vehicle item) {
		return repository.save(item);
	}

	@Override
	public Vehicle updateItem(Vehicle item) {
		return repository.save(item);
	}

	@Override
	public void deleteItem(Vehicle item) {
		repository.delete(item.getId());
	}
}
