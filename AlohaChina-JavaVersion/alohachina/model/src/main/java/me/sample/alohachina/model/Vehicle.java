/**
 * 
 */
package me.sample.alohachina.model;

import java.io.Serializable;
import java.sql.Time;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.PrimaryKeyJoinColumn;
import javax.persistence.Table;

/**
 * @author jianwang
 *
 */
@Entity
@Table(name="vehicle")
public class Vehicle implements Serializable {

	/**
	 * serial version UID
	 */
	private static final long serialVersionUID = -4823669347144161674L;

	@Id
	@Column(name="vehicle_id")
	@GeneratedValue(strategy = GenerationType.AUTO)
	private int id;
	
	@Column(name="vehicle_license_number")
	private String licenseNumber;
	
	@Column(name="vehicle_capacity")
	private int capacity;
	
	@Column(name="vehicle_fix_cost")
	private int fixCost;
	
	@Column(name="vehicle_float_cost")
	private int floatCost;
	
	@Column(name="vehicle_service_start_time")
	private Time serviceStartTime;
	
	@Column(name="vehicle_service_end_time")
	private Time serviceEndTime;
	
	/**
	 * @return the id
	 */
	public int getId() {
		return id;
	}
	/**
	 * @param id the id to set
	 */
	public void setId(int id) {
		this.id = id;
	}
	/**
	 * @return the capacity
	 */
	public int getCapacity() {
		return capacity;
	}
	/**
	 * @param capacity the capacity to set
	 */
	public void setCapacity(int capacity) {
		this.capacity = capacity;
	}
	/**
	 * @return the fixCost
	 */
	public int getFixCost() {
		return fixCost;
	}
	/**
	 * @param fixCost the fixCost to set
	 */
	public void setFixCost(int fixCost) {
		this.fixCost = fixCost;
	}
	/**
	 * @return the floatCost
	 */
	public int getFloatCost() {
		return floatCost;
	}
	/**
	 * @param floatCost the floatCost to set
	 */
	public void setFloatCost(int floatCost) {
		this.floatCost = floatCost;
	}
	/**
	 * @return the serviceStartTime
	 */
	public Time getServiceStartTime() {
		return serviceStartTime;
	}
	/**
	 * @param serviceStartTime the serviceStartTime to set
	 */
	public void setServiceStartTime(Time serviceStartTime) {
		this.serviceStartTime = serviceStartTime;
	}
	/**
	 * @return the serviceEndTime
	 */
	public Time getServiceEndTime() {
		return serviceEndTime;
	}
	/**
	 * @param serviceEndTime the serviceEndTime to set
	 */
	public void setServiceEndTime(Time serviceEndTime) {
		this.serviceEndTime = serviceEndTime;
	}
	
	
}
