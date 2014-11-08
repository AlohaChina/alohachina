/**
 * 
 */
package me.sample.alohachina.repository;

import me.sample.alohachina.model.Vehicle;

import org.springframework.data.repository.CrudRepository;
import org.springframework.data.repository.PagingAndSortingRepository;
import org.springframework.stereotype.Repository;

/**
 * @author jianwang
 *
 */
@Repository
public interface VehicleRepository extends CrudRepository<Vehicle, Integer>, PagingAndSortingRepository<Vehicle, Integer> {

}
